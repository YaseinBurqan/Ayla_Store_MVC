using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule;

[ConnectionKey("Ayla_Store_MVC_Database"), Module("AylaStoreModule"), TableName("Category")]
[DisplayName("Category"), InstanceName("Category")]
[ReadPermission("Category")]
[ModifyPermission("Category")]

[LookupScript]
public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), Size(50), QuickSearch, NameProperty]
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

    [DisplayName("Photo")]
    public string Photo
    {
        get => fields.Photo[this];
        set => fields.Photo[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public StringField Photo;

    }
}