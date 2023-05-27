﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule.Columns;

[ColumnsScript("AylaStoreModule.ProductImage")]
[BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
public class ProductImageColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ProductName { get; set; }
    [EditLink]
    public string Image { get; set; }
}