using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule;

[ConnectionKey("Ayla_Store_MVC_Database"), Module("AylaStoreModule"), TableName("Product")]
[DisplayName("Product"), InstanceName("Product")]
[ReadPermission("Product")]
[ModifyPermission("Product")]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), Size(100), QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Description")]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Price"), Size(18)]
    public decimal? Price
    {
        get => fields.Price[this];
        set => fields.Price[this] = value;
    }

    [DisplayName("Category"), ForeignKey("Category", "Id"), LeftJoin(jCategory), TextualField(nameof(CategoryName))]
    [LookupEditor(typeof(CategoryRow))]
    public int? CategoryId
    {
        get => fields.CategoryId[this];
        set => fields.CategoryId[this] = value;
    }

    [DisplayName("Photo"), ImageUploadEditor]
    public string Photo
    {
        get => fields.Photo[this];
        set => fields.Photo[this] = value;
    }

    [DisplayName("Quantity")]
    public int? Quantity
    {
        get => fields.Quantity[this];
        set => fields.Quantity[this] = value;
    }

    [DisplayName("Type"), Size(50)]
    public string Type
    {
        get => fields.Type[this];
        set => fields.Type[this] = value;
    }

    [DisplayName("Supplier Name"), Column("supplierName"), Size(100)]
    public string SupplierName
    {
        get => fields.SupplierName[this];
        set => fields.SupplierName[this] = value;
    }

    [DisplayName("Entry Date")]
    public DateTime? EntryDate
    {
        get => fields.EntryDate[this];
        set => fields.EntryDate[this] = value;
    }

    [DisplayName("Review Url")]
    public string ReviewUrl
    {
        get => fields.ReviewUrl[this];
        set => fields.ReviewUrl[this] = value;
    }

    [DisplayName("Category Name"), Expression($"{jCategory}.[Name]")]
    public string CategoryName
    {
        get => fields.CategoryName[this];
        set => fields.CategoryName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public DecimalField Price;
        public Int32Field CategoryId;
        public StringField Photo;
        public Int32Field Quantity;
        public StringField Type;
        public StringField SupplierName;
        public DateTimeField EntryDate;
        public StringField ReviewUrl;

        public StringField CategoryName;
    }
}