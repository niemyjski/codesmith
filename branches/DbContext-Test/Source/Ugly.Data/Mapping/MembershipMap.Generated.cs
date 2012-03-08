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
    public partial class MembershipMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ugly.Data.Entities.Membership>
    {
        public MembershipMap()
        {
            // table
            ToTable("Membership", "dbo");

            // keys
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsRequired();
            Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(256)
                .IsRequired();
            Property(t => t.LoweredUserName)
                .HasColumnName("LoweredUserName")
                .HasMaxLength(256)
                .IsRequired();
            Property(t => t.MobileAlias)
                .HasColumnName("MobileAlias")
                .HasMaxLength(16)
                .IsOptional();
            Property(t => t.Password)
                .HasColumnName("Password")
                .HasMaxLength(128)
                .IsRequired();
            Property(t => t.PasswordFormat)
                .HasColumnName("PasswordFormat")
                .IsRequired();
            Property(t => t.PasswordSalt)
                .HasColumnName("PasswordSalt")
                .HasMaxLength(128)
                .IsRequired();
            Property(t => t.MobilePIN)
                .HasColumnName("MobilePIN")
                .HasMaxLength(16)
                .IsOptional();
            Property(t => t.Email)
                .HasColumnName("Email")
                .HasMaxLength(256)
                .IsRequired();
            Property(t => t.LoweredEmail)
                .HasColumnName("LoweredEmail")
                .HasMaxLength(256)
                .IsRequired();
            Property(t => t.PasswordQuestion)
                .HasColumnName("PasswordQuestion")
                .HasMaxLength(256)
                .IsOptional();
            Property(t => t.PasswordAnswer)
                .HasColumnName("PasswordAnswer")
                .HasMaxLength(128)
                .IsOptional();
            Property(t => t.IsApproved)
                .HasColumnName("IsApproved")
                .IsRequired();
            Property(t => t.IsLockedOut)
                .HasColumnName("IsLockedOut")
                .IsRequired();
            Property(t => t.IsAnonymous)
                .HasColumnName("IsAnonymous")
                .IsRequired();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();
            Property(t => t.LastLoginDate)
                .HasColumnName("LastLoginDate")
                .IsRequired();
            Property(t => t.LastActivityDate)
                .HasColumnName("LastActivityDate")
                .IsRequired();
            Property(t => t.LastPasswordChangedDate)
                .HasColumnName("LastPasswordChangedDate")
                .IsRequired();
            Property(t => t.LastLockoutDate)
                .HasColumnName("LastLockoutDate")
                .IsRequired();
            Property(t => t.FailedPasswordAttemptCount)
                .HasColumnName("FailedPasswordAttemptCount")
                .IsRequired();
            Property(t => t.FailedPasswordAttemptWindowStart)
                .HasColumnName("FailedPasswordAttemptWindowStart")
                .IsRequired();
            Property(t => t.FailedPasswordAnswerAttemptCount)
                .HasColumnName("FailedPasswordAnswerAttemptCount")
                .IsRequired();
            Property(t => t.FailedPasswordAnswerAttemptWindowStart)
                .HasColumnName("FailedPasswordAnswerAttemptWindowStart")
                .IsRequired();
            Property(t => t.Comment)
                .HasColumnName("Comment")
                .HasMaxLength(16)
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
