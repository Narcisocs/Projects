﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Collections;

public partial class Design : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "<div id='usersContainer'> " +
                      "<table id='listaUsuario'> "  +
                      " <tr> " +
                      "   <td> " + 
                      "     <div class='usuario' data-user-id='0' chat-id='0'> " + 
                      "             <div class='usuario_img'><image class='imagem' src='../Imagens/narciso.jpg' height='32px' width='32px'/></div> "  +
                      "             <div class='usuario_nome'><span>Narciso</span></div> " +
                      "             <div class='usuario_ult_msg'>teste resposta do narciso aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</div> " +
                      "             <div class='usuario_data'>17 jan</div> " + 
                      "     </div>" +
                      "   </td> " + 
                      "   <td> "  +
                      "     <div class='usuario' data-user-id='1' chat-id='1'> " +
                      "             <div class='usuario_img'><image class='imagem' src='../Imagens/gato.jpg' height='32px' width='32px'/></div> " +
                      "             <div class='usuario_nome'><span>Gato</span></div> " +
                      "             <div class='usuario_ult_msg'>teste resposta do gato aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</div> " +
                      "             <div class='usuario_data'>18 jan</div> " + 
                      "     </div>"  +
                      "   </td> " +
                      "   <td> " +
                      "     <div class='usuario' data-user-id='2' chat-id='2'> " +
                      "             <div class='usuario_img'><image class='imagem' src='../Imagens/tigres.jpg' height='32px' width='32px'/></div> " +
                      "             <div class='usuario_nome'><span>Tigres</span></div> " +
                      "             <div class='usuario_ult_msg'>teste resposta do tigre aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</div> " +
                      "             <div class='usuario_data'>19 jan</div> " + 
                      "     </div>" +
                      "   </td> " +
                      "   <td> " +
                      "     <div class='usuario' data-user-id='3' chat-id='3'> " +
                      "             <div class='usuario_img'><image class='imagem' src='../Imagens/borboleta.jpg' height='32px' width='32px'/></div> " +
                      "             <div class='usuario_nome'><span>borboleta</span></div>" +
                      "             <div class='usuario_ult_msg'>teste resposta da borboleta aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</div> " +
                      "             <div class='usuario_data'>20 jan</div> " + 
                      "     </div>" +
                      "   </td> " +
                      "   <td> " +
                      "     <div class='usuario' data-user-id='4' chat-id='4'> " +
                      "             <div class='usuario_img'><image class='imagem' src='../Imagens/cachorro.jpg' height='32px' width='32px'/></div> " +
                      "             <div class='usuario_nome'><span>Cachorro</span></div> " +
                      "             <div class='usuario_ult_msg'>teste resposta do cachorro aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</div> " +
                      "             <div class='usuario_data'>21 jan</div> " + 
                      "     </div>" +
                      "   </td> " +
                      " </tr> " + 
                      "</table> " +
                      "</div>";

        Label2.Text = /*"<ul id='usuario_list'> " + 
                      "     <li> " +
                      "     <div class='usuario_pesq' data-user-id='0'> " + 
                      "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/narciso.jpg' height='32px' width='32px'/></div> "  +
                      "        <div class='usuario_pesq_nome'><span>Narciso</span></div> " +
                      "     </div>" +
                      "     </li> " +
                      "     <li> " +
                      "     <div class='usuario_pesq' data-user-id='1'> " +
                      "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/adriano.jpg' height='32px' width='32px'/></div> " +
                      "        <div class='usuario_pesq_nome'><span>Adriano</span></div> " +
                      "     </div>" +
                      "     </li> " +
                      "     <li> " +
                      "     <div class='usuario_pesq' data-user-id='2'> " +
                      "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/fabiano.jpg' height='32px' width='32px'/></div> " +
                      "        <div class='usuario_pesq_nome'><span>Fabiano</span></div> " +
                      "     </div>" +
                      "     </li> " +
                      "     <li> " +
                      "     <div class='usuario_pesq' data-user-id='3'> " +
                      "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/marcos.jpg' height='32px' width='32px'/></div> " +
                      "        <div class='usuario_pesq_nome'><span>Marcos</span></div> " +
                      "     </div>" +
                      "     </li> " +
                      "     <li> " +
                      "     <div class='usuario_pesq' data-user-id='4'> " +
                      "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/anderson.jpg' height='32px' width='32px'/></div> " +
                      "        <div class='usuario_pesq_nome'><span>Anderson</span></div> " +
                      "     </div>" +
                      "     </li> " +
                      "     <li> " +
                      "     <div class='usuario_pesq' data-user-id='5'> " +
                      "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/jardel.jpg' height='32px' width='32px'/></div> " +
                      "        <div class='usuario_pesq_nome'><span>Jardel</span></div> " +
                      "     </div>" +
                      "     </li> " +
                      "</ul> ";*/ "";

        Session["UsuarioID"] = 0;
    }

    [WebMethod]
    public static string retornaMensagens(int pessoa)
    {
        string mensagens = "<div class='mensagem_container'> ";
        if (pessoa == 1)
            mensagens += "    <div class='msg_usuario' data-user-id='1'> " +
               "        <div class='msg_imagem'><image src='../Imagens/gato.jpg' height='32px' width='32px'/></div> " +
               "        <div class='msg_nome'>Gato</div> " +
               "        <div class='msg_resposta'><span><p>teste resposta do gato aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa<p></span></div> " +
               "        <div class='msg_data'>1/2,1:00pm</div> " + 
               "    </div> ";
        else if(pessoa == 2)
            mensagens += "    <div class='msg_usuario' data-user-id='2'> " +
               "        <div class='msg_imagem'><image src='../Imagens/tigres.jpg' height='32px' width='32px'/></div> " +
               "        <div class='msg_nome'>Tigres</div> " +
               "        <div class='msg_resposta'><span><p>teste resposta do tigre aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</p></span></div> " +
               "        <div class='msg_data'>2/2,2:00pm</div> " +
               "    </div> ";
        else if(pessoa == 3)
            mensagens += "    <div class='msg_usuario' data-user-id='3'> " +
               "        <div class='msg_imagem'><image src='../Imagens/borboleta.jpg' height='32px' width='32px'/></div> " +
               "        <div class='msg_nome'>borboleta</div> " +
               "        <div class='msg_resposta'><span><p>teste resposta do borboleta aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</p></span></div> " +
               "        <div class='msg_data'>3/2,3:00pm</div> " +
               "    </div> ";
        else if(pessoa == 4)
            mensagens += "    <div class='msg_usuario' data-user-id='4'> " +
               "        <div class='msg_imagem'><image src='../Imagens/cachorro.jpg' height='32px' width='32px'/></div> " +
               "        <div class='msg_nome'>Cachorro</div> " +
               "        <div class='msg_resposta'><span><p>teste resposta do cachorro aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa<p></span></div> " +
               "        <div class='msg_data'>4/2,4:00pm</div> " +
               "    </div> ";
        
        mensagens += "    <div class='msg_usuario' data-user-id='0'> " +
               "        <div class='msg_imagem'><image src='../Imagens/narciso.jpg' height='32px' width='32px'/></div> " +  
               "        <div class='msg_nome'>Narciso</div> " +
               "        <div class='msg_resposta'><span><p>resposta do teste bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</p></span></div> " +
               "        <div class='msg_data'>6/2,6:00pm</div> " +
	           "    </div> " +
               "</div>";
        
        return mensagens;
    }

    [WebMethod]
    public static string adicionaMensagem(string usuario_atual, string mensagem)
    {
        string[] array_msg = mensagem.Split('\n');
        string mensagens = "";

        if (usuario_atual != HttpContext.Current.Session["UsuarioID"].ToString())
        {
            mensagens += "    <div class='msg_usuario' data-user-id='0'> " +
                   "        <div class='msg_imagem'><image src='../Imagens/narciso.jpg' height='32px' width='32px'/></div> " +
                   "        <div class='msg_nome'>Narciso</div> " +
                   "        <div class='msg_resposta'><span>";

            for (int i = 0; i < array_msg.Length; i++)
                mensagens += "<p>" + array_msg[i] + "</p>";

            mensagens += "    </span></div> " +
                        "        <div class='msg_data'>" + DateTime.Now.Day + "/" + DateTime.Now.Month + "," + DateTime.Now.ToShortTimeString();

            if (Convert.ToInt32(DateTime.Now.Hour) > 12)
                mensagens += "pm";
            else
                mensagens += "am";
            mensagens += "</div> " +
                   "    </div> ";
        }
        else
        {
            for (int i = 0; i < array_msg.Length; i++)
                mensagens += "<p>" + array_msg[i] + "</p>";
        }

        return mensagens;
    }

    [WebMethod]
    public static string buscaUsuario(string usuario)
    {
        string retorno = "";

        ArrayList listaDeUsuarios = new ArrayList();
        listaDeUsuarios.Add("Narciso");
        listaDeUsuarios.Add("Gato");
        listaDeUsuarios.Add("Tigres");
        listaDeUsuarios.Add("Borboleta");
        listaDeUsuarios.Add("Cachorro");
        
        int count = 0;

        for (int i = 0; i < listaDeUsuarios.Count; i++)
            if (listaDeUsuarios[i].ToString().ToLower().IndexOf(usuario) != -1)
            {
                if(count == 0)
                    retorno += "<li class='selected'>";
                else
                    retorno += "<li>";

                if (listaDeUsuarios[i].ToString().Equals("Narciso"))
                    retorno += //"     <li> " +
                          "     <div class='usuario_pesq' data-user-id='0'> " +
                          "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/narciso.jpg' height='32px' width='32px'/></div> " +
                          "        <div class='usuario_pesq_nome'><span>" + listaDeUsuarios[i] + "</span></div> " +
                          "     </div>" +
                          "     </li> ";
                else if (listaDeUsuarios[i].ToString().Equals("Gato"))
                    retorno += //"     <li> " +
                          "     <div class='usuario_pesq' data-user-id='1'> " +
                          "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/gato.jpg' height='32px' width='32px'/></div> " +
                          "        <div class='usuario_pesq_nome'><span>" + listaDeUsuarios[i] + "</span></div> " +
                          "     </div>" +
                          "     </li> ";
                else if (listaDeUsuarios[i].ToString().Equals("Tigres"))
                    retorno += //"     <li> " +
                          "     <div class='usuario_pesq' data-user-id='2'> " +
                          "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/tigres.jpg' height='32px' width='32px'/></div> " +
                          "        <div class='usuario_pesq_nome'><span>" + listaDeUsuarios[i] + "</span></div> " +
                          "     </div>" +
                          "     </li> ";
                else if (listaDeUsuarios[i].ToString().Equals("Borboleta"))
                    retorno += //"     <li> " +
                          "     <div class='usuario_pesq' data-user-id='3'> " +
                          "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/borboleta.jpg' height='32px' width='32px'/></div> " +
                          "        <div class='usuario_pesq_nome'><span>" + listaDeUsuarios[i] + "</span></div> " +
                          "     </div>" +
                          "     </li> ";
                else if (listaDeUsuarios[i].ToString().Equals("Cachorro"))
                    retorno += //"     <li> " +
                          "     <div class='usuario_pesq' data-user-id='4'> " +
                          "        <div class='usuario_pesq_img'><image class='imagem' src='../Imagens/cachorro.jpg' height='32px' width='32px'/></div> " +
                          "        <div class='usuario_pesq_nome'><span>" + listaDeUsuarios[i] + "</span></div> " +
                          "     </div>" +
                          "     </li> ";
                count++;
            }
        return retorno;
    }
}