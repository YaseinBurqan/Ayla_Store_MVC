using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule.Columns;

[ColumnsScript("AylaStoreModule.ContactUs")]
[BasedOnRow(typeof(ContactUsRow), CheckNames = true)]
public class ContactUsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
}