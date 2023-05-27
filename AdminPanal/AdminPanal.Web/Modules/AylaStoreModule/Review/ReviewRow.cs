using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule;

[ConnectionKey("Ayla_Store_MVC_Database"), Module("AylaStoreModule"), TableName("Review")]
[DisplayName("Review"), InstanceName("Review")]
[ReadPermission("Review")]
[ModifyPermission("Review")]
public sealed class ReviewRow : Row<ReviewRow.RowFields>, IIdRow, INameRow
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

    [DisplayName("Email"), Size(100)]
    public string Email
    {
        get => fields.Email[this];
        set => fields.Email[this] = value;
    }

    [DisplayName("Description"), Size(250)]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Entry Date")]
    public DateTime? EntryDate
    {
        get => fields.EntryDate[this];
        set => fields.EntryDate[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Email;
        public StringField Description;
        public DateTimeField EntryDate;

    }
}