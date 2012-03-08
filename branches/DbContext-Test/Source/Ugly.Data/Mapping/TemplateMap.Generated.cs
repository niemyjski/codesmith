﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ugly.Data.Mapping
{
    public partial class TemplateMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ugly.Data.Entities.Template>
    {
        public TemplateMap()
        {
            // table
            ToTable("Template", "dbo");

            // keys
            HasKey(t => t.TemplateID);

            // Properties
            Property(t => t.TemplateID)
                .HasColumnName("TemplateID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.TemplateName)
                .HasColumnName("TemplateName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
            HasMany(t => t.TemplateList)
                .WithMany(t => t.TemplateList1)
                .Map(m =>
                {
                    m.ToTable("TemplateDepend", "dbo");
                    m.MapLeftKey("LinkID");
                    m.MapRightKey("DependID");
                });

            InitializeMapping();
        }
    }
}
