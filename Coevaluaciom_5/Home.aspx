<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
        EnableEventValidation="false"
    AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container d-flex" style="flex-direction: column">
          <h2 class="text text-center">Usuarios</h2>
         <asp:Button ID="Button1" runat="server" Text="Agregar Usuario" 
              class="btn btn-danger btn-lg btn-block"
            onCommand="onbtnAdd"
             />
    <table class="table table-striped table-dark">
        <thead>
            <tr>
                
                <th class="table-dark" scope="col">ID</th>
                <th class="table-dark" scope="col">Nombre</th>
                <th class="table-dark" scope="col">Descripcion</th>
                <th class="table-dark" scope="col">Acciones</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterPersona" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("Id") %></th>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("Description") %></td>

                        <td>
                            <div style="display: flex; justify-content:space-around;">
                                <asp:Button ID="BtnEdit" runat="server" Text="Editar" onCommand="btnEdit"
                                    class="btn btn-primary btn-lg btn-block" CommandName='<%# Eval("Id") %>'
                                    CommandArgument='<%# Eval("Id") %>' />
                                <asp:Button ID="BtnDelete" runat="server" Text="X" onCommand="btnDeletePelicula"
                                    class="btn btn-danger btn-lg btn-block" CommandName='<%# Eval("Id") %>'
                                    CommandArgument='<%# Eval("Id") %>' />
                            </div>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
         </div>
</asp:Content>