﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using CodeSmith.Engine;

namespace CodeSmith.SchemaHelper.NHibernate
{
    public class NHibernateProperty : PropertyBase<XElement>
    {
        public static readonly string[] DefaultAttributes = new[] { "name", "column", "type", NHibernateUtilities.NHibernateType, NHibernateUtilities.GeneratorClass };

        private string _safeName;

        public NHibernateProperty(XElement element, IEntity entity)
            : base(element, entity)
        {
        }

        public override void Initialize()
        {
            // ReSharper disable PossibleNullReferenceException
            var name = PropertySource.Attribute("name").Value;
            var type = PropertySource.Attribute("type").Value;
            var column = PropertySource.Attribute("column").Value;
            
            var lengthAttribute = PropertySource.Attribute("length");
            int? length = null;
            if (lengthAttribute != null)
            {
                int lengthInt;
                if (Int32.TryParse(lengthAttribute.Value, out lengthInt))
                    length = lengthInt;
            }

            KeyName = name;
            Name = name;
            GetterAccess = "public";
            SetterAccess = "public";
            SystemType = NHibernateUtilities.FromNHibernateType(type, length);

            _safeName = column;

            ExtendedProperties.Add(NHibernateUtilities.NHibernateType, type);

            var generator = PropertySource.Descendant("generator", ((NHibernateEntity)Entity).XmlNamespace);
            if (generator != null)
                ExtendedProperties.Add(NHibernateUtilities.GeneratorClass, generator.Attribute("class").Value);

            var customAttributes = PropertySource
                .Attributes()
                .Where(a => !DefaultAttributes.Contains(a.Name.ToString()));
            foreach (var customAttribute in customAttributes)
            {
                // Special case, always preserve length from DB.
                if (customAttribute.Name.ToString() == "length")
                    continue;

                ExtendedProperties.Add(customAttribute.Name.ToString(), customAttribute.Value);
            }
            // ReSharper restore PossibleNullReferenceException
        }

        public override string GetSafeName()
        {
            return _safeName;
        }

        
    }
}