﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[PrimaryKey("RuleId", "ProductId")]
[Table("Discount_rule")]
[Index("RuleId", Name = "UQ__Discount__70A80C77D2FFD64D", IsUnique = true)]
public partial class DiscountRule
{
    [Key]
    [Column("Rule_id")]
    [StringLength(20)]
    [Unicode(false)]
    public string RuleId { get; set; }

    [Column("Day_to_expired")]
    public byte DayToExpired { get; set; }

    [Column("Discount_percent")]
    public double DiscountPercent { get; set; }

    [Key]
    [Column("Product_id")]
    [StringLength(20)]
    [Unicode(false)]
    public string ProductId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("DiscountRules")]
    public virtual Product Product { get; set; }
}