﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TextbookSubscription.Domain.Entity;

namespace TextbookSubscription.Domain.EntityMapping
{
    public class SchoolMap:EntityTypeConfiguration<School>
    {
        public SchoolMap()
        {
            //PrimaryKey
            HasKey(t => t.SchoolID);
            //Property(t => t.SchoolID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Properties
            Property(t => t.SchoolID).IsRequired();
            Property(t => t.SchoolName).IsRequired();
            Property(t => t.Contact).IsRequired();
            Property(t => t.Telephone).IsRequired();
            Property(t => t.Telephone).HasMaxLength(11);

            //Table
            ToTable("School", "dbo");

            Ignore(t => t.ID);
            //Ignore(t=>t.)
        }
    }
}
