using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule.Columns;

[ColumnsScript("AylaStoreModule.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
}