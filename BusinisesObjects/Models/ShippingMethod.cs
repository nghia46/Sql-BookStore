﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.Models;

[Table("shipping_method")]
public partial class ShippingMethod
{
    [Key]
    [Column("method_id")]
    public int MethodId { get; set; }

    [Column("method_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string MethodName { get; set; }

    [Column("cost")]
    public int? Cost { get; set; }

    [InverseProperty("ShippingMethod")]
    public virtual ICollection<CustOrder> CustOrders { get; set; } = new List<CustOrder>();
}