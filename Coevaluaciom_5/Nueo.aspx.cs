using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Nueo : System.Web.UI.Page
{
    Persona persona = new Persona();
    PersonaService personaService = new PersonaService();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btnClick(object sender, EventArgs e)
    {
        persona.Name = TextBoxName.Text;
        persona.Description = TextBoxDescription.Text;

        personaService.CreatePersona(persona);

        Response.Redirect("/Home.aspx");
    }

}