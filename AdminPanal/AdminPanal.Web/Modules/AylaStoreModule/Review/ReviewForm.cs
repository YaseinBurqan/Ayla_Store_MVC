using Serenity.ComponentModel;
using System;

namespace AdminPanal.AylaStoreModule.Forms;

[FormScript("AylaStoreModule.Review")]
[BasedOnRow(typeof(ReviewRow), CheckNames = true)]
public class ReviewForm
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public DateTime EntryDate { get; set; }
}