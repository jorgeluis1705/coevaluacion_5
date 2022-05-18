using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    PersonaService personaService = new PersonaService();
    List<Persona> personaList;
    protected void Page_Init(object sender, EventArgs e)
    {
        this.personaList = personaService.GetAllPersonas();


        RepeaterPersona.DataSource = personaList;
        RepeaterPersona.DataBind();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.personaList = personaService.GetAllPersonas();
        RepeaterPersona.DataSource = personaList;
        RepeaterPersona.DataBind();
    }
    public void btnEdit(object sender, CommandEventArgs e)
    {
        Response.Redirect("/Detalles.aspx?id=" + e.CommandName);
    }
    public void btnDeletePelicula(object sender, CommandEventArgs e)
    {

        personaService.DeletePersona(int.Parse(e.CommandName));
        this.Page_Load(sender, e);
    }
    public void onbtnAdd(object sender, CommandEventArgs e)
    {
        Response.Redirect("/Nueo.aspx");

    }
}