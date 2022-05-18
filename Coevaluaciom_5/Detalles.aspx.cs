using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Detalles : System.Web.UI.Page
{
    PersonaService personaService = new PersonaService();
    Persona persona = new Persona();
    int idPersona = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            idPersona = (Request.QueryString["id"] != null ? int.Parse(Request.QueryString["id"]) : 0);
            persona = personaService.GetOnePersona(idPersona);

            personaNameEdit.Text = persona.Name;
            personaDescEdit.Text = persona.Description;
            persona.Id = idPersona;

        }
    }
    public void btnClickSuccessEditPelicula(object sender, EventArgs e)
    {
        persona.Name = personaNameEdit.Text;
        persona.Description = personaDescEdit.Text;
        var nestedID = int.Parse(Request.QueryString["id"]);
        personaService.UpdatePersona(persona, nestedID);
        Response.Redirect("/Home.aspx");
    }

}