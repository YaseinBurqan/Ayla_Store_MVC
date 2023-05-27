using Serenity.ComponentModel;

namespace AdminPanal.AylaStoreModule.Forms;

[FormScript("AylaStoreModule.ContactUs")]
[BasedOnRow(typeof(ContactUsRow), CheckNames = true)]
public class ContactUsForm
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
}