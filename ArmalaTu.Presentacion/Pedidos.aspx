<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="ArmalaTu.Presentacion.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style6">
        MANTENEDOR PEDIDOS</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label0" runat="server" Text="ID Pedido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtIDpedido" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbNombre" runat="server" Text="NOMBRE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtnombre" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbDireccion" runat="server" Text="DIRECCION"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtdireccion" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbbebida" runat="server" Text="BEBIDA"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtbebida" runat="server" Width="203px"></asp:TextBox>
    </p>
 
    
   
    <p>
        <asp:Label ID="lbServir" runat="server" Text="¿SERVIR?"></asp:Label>
        &nbsp;<asp:DropDownList ID="ddServir" runat="server">
        </asp:DropDownList>
        &nbsp;<asp:Label ID="lbmessage" runat="server" Text=""></asp:Label>
    </p>

    <p>
        <asp:Label ID="Label1" runat="server" Text="ID Pizza"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtID_pizza" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbdescuento" runat="server" Text="DESCUENTO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtdescuento" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Total"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtTotal" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnread" runat="server" OnClick="btnread_Click" Text="Buscar" Width="428px" />
    </p>
    <p>
        <asp:Button ID="btncreate" runat="server" OnClick="btncreate_Click" Text="Crear" Width="426px" />
    </p>
    <p>
        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Actualizar" Width="424px" />
    </p>
    <p>
        <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" Width="425px" />
    </p>
    <p>
        <asp:Button ID="btnlimpiar" runat="server" OnClick="btnlimpiar_Click" Text="Limpiar Campos" Width="425px" />
    </p>
</asp:Content>
