﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.Models;

[Table("address")]
public partial class Address
{
    [Key]
    [Column("address_id")]
    public int AddressId { get; set; }

    [Column("street_number")]
    [StringLength(50)]
    [Unicode(false)]
    public string StreetNumber { get; set; }

    [Column("street_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string StreetName { get; set; }

    [Column("city")]
    [StringLength(255)]
    [Unicode(false)]
    public string City { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Addresses")]
    public virtual Country Country { get; set; }

    [InverseProperty("DestAddress")]
    public virtual ICollection<CustOrder> CustOrders { get; set; } = new List<CustOrder>();

    [InverseProperty("Address")]
    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
}