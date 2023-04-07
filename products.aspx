<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="adminpage.orderlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="dash">
   
    
    <div class="table_d">
        <h2>Product List</h2>
        <table >
            <thead>
                <tr>
                    <th>Product_id</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Image</th>
                    <th>Category</th>
                    <th>Date</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>#568549</td>
                    <td>Banana</td>
                    <td>100.00</td>                    
                    <td>100</td>
                    <td>100</td>
                    <td>Fruits</td>
                    <td>26 march</td>
                     <td>
                        <div class="tb_btn">
                            <asp:Button ID="Button1" runat="server" class="act_btn" Text="Edit" OnClick="Button1_Click"  />
                        </div>
                        <div class="tb_btn">
                            <asp:Button ID="Button8" runat="server" class="act_btn" Text="Delete"  />
                        </div>
                    </td>
                    
                </tr>
                 
            </tbody>
        </table>
    </div>
 </div>
</asp:Content>
