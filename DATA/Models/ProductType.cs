﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("Product_type")]
public partial class ProductType
{
    [Key]
    [Column("Type_id")]
    [StringLength(20)]
    [Unicode(false)]
    public string TypeId { get; set; }

    [Column("Type_name")]
    [StringLength(100)]
    public string TypeName { get; set; }

    [InverseProperty("Type")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}