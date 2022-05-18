<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Nueo.aspx.cs" Inherits="Nueo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  Runat="Server"
>
  <div>
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox
      class="form-control"
      ID="TextBoxName"
      runat="server"
      required="true"
      Text="."
    ></asp:TextBox>
  </div>

  <div class="">
    <asp:Label
      ID="Label2"
      type="text"
      runat="server"
      Text="Descripcion"
    ></asp:Label>
    <asp:TextBox
      class="form-control"
      ID="TextBoxDescription"
      runat="server"
      required="true"
      Text="."
    ></asp:TextBox>
    <asp:Button
      ID="Button1"
      runat="server"
      Text="Añadir"
      class="btn btn-warning"
      style="margin-top: 0.5rem"
      onClick="btnClick"
    />
  </div>
</asp:Content>
