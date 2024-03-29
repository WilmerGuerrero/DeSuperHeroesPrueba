﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeSuperHeroesPrueba.Models
{
    [Table("stock")]
    public class stock
    {
        [Key]
        public int id { get; set; }

        
        public string nombre { get; set; }
        
        public int existencia { get; set; }
      
        public DateTime ultimaFecha { get; set; }
        
        
         public class mapear
        {
            public mapear(EntityTypeBuilder<stock> mapeo)
            {
                mapeo.HasKey(x => x.id);
                mapeo.Property(x => x.nombre).HasColumnName("tipoProducto");
                mapeo.Property(x => x.existencia).HasColumnName("existencia");
                mapeo.Property(x => x.ultimaFecha).HasColumnName("ultimaFecha");
                mapeo.ToTable("stock");
            }
        }


    }
}