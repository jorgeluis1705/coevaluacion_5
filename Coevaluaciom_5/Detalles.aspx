<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detalles.aspx.cs" Inherits="Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  Runat="Server"
>
  <div class="container d-flex" style="flex-direction: column">
    <h2 class="text text-center">Detalles del Usuario</h2>
    <div>
      <p>Nombre</p>
      <asp:TextBox
        required="true"
        class="form-control"
        ID="personaNameEdit"
        runat="server"
      ></asp:TextBox>
      <p>Descripcion</p>
      <asp:TextBox
        required="true"
        class="form-control"
        ID="personaDescEdit"
        runat="server"
      ></asp:TextBox>
    </div>
    <asp:Button
      ID="btnEdit"
      runat="server"
      Text="Editar Usuario"
      CssClass="btn btn-info "
      OnClick="btnClickSuccessEditPelicula"
    />
  </div>
</asp:Content>
