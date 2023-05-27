using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule.Columns;

[ColumnsScript("AylaStoreModule.Review")]
[BasedOnRow(typeof(ReviewRow), CheckNames = true)]
public class ReviewColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public DateTime EntryDate { get; set; }
}