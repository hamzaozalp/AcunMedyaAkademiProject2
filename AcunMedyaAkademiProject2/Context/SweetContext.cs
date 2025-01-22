﻿using AcunmedyaAkademiProject2.Entities;
using AcunMedyaAkademiProject2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiProject2.Context
{
    public class SweetContext : DbContext

    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider>  Sliders { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}