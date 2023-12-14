Imports System.IO
Imports System.Net.Mail

Public Class Form1
    Dim f As String
    Dim c As Integer
    Dim sp = CreateObject("sapi.spvoice")
    Sub jouer()
        AxWindowsMediaPlayer1.URL = f
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox1.Image = My.Resources.photo_minshawi
        PictureBox2.Image = My.Resources.SADRY
        RichTextBox1.Text = "Muhammad Siddik Al-Minshawi est un imam né en 1920 dans le village « Munsha’a» à Sohage (Égypte), il est un des meilleurs récitateurs égyptiens du Coran. Issu d’une ancienne famille connue pour sa bonne récitation des versets, son père est le Sheikh Siddik Al-Minshawi et son frère se nomme cheikh Mahmoud Al-Minshawi.Âgé de huit ans, Muhammad Siddik Al-Minshawi a terminé la mémorisation du saint coran.  Connu pour la beauté de sa voix et sa bonne psalmodie, il a réalisé beaucoup d’enregistrements et de récitations du Coran dans les mosquées Al Aqsa, le Koweït, la Syrie et la Libye. De nombreuses stations de radio et chaines de télévision diffusent sa récitation coranique, des sites sur internet également. Muhammad Siddik Al-Minshawi a aussi participé à des récitations enregistrées avec les deux récitateurs : Kamel Al Bahtimi et Fouad Al Aroussi. Mouhammad Siddik Al-Minshawi s’est marié deux fois, il a eu quatre garçons et deux filles avec la première épouse en plus de cinq garçons et quatre filles avec la seconde femme. En 1968, sa deuxième épouse meurt au pèlerinage. Muhammad Siddik Al-Minshawi était toujours une cible pour ses ennemis qui ont tenté de le tuer en l’intoxiquant lors d’une soirée de récitation, mais Dieu l’a sauvé de leur complot. Muhammad Siddik Al-Minshawi est décédé le vendredi 20 juin 1969 ( 5 Rabi’e thani, 1389 d e l'hégire) suite à une maladie. Qu’Allah lui fasse miséricorde !"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.BackColor = Color.Green Then
            Label1.BackColor = Color.Yellow
        ElseIf Label1.BackColor = Color.Yellow Then
            Label1.BackColor = Color.Red
        ElseIf Label1.BackColor = Color.Red Then
            Label1.BackColor = Color.Green
        End If


        If Label2.Text = "Contact" Then
            Label2.Text = "Contact:91"
        ElseIf Label2.Text = "Contact:91" Then
            Label2.Text = "Contact:91-68"
        ElseIf Label2.Text = "Contact:91-68" Then
            Label2.Text = "Contact:91-68-41"
        ElseIf Label2.Text = "Contact:91-68-41" Then
            Label2.Text = "Contact:91-68-41-33"
        ElseIf Label2.Text = "Contact:91-68-41-33" Then
            Label2.Text = "Contact"
        End If
        Label3.Text = Date.Now.ToLongTimeString
        Label4.Text = Date.Now.ToShortDateString


    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Butfatiha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butfatiha.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_001.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._001)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub nabaye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nabaye.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_78.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._078)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butnaziante.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_79.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._079)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butanbassa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butanbassa.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_80.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._080)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub buttakwir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttakwir.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_81.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._081)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButINFITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButINFITAR.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_82.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._082)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButMOUTAFIFINE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMOUTAFIFINE.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_83.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._083)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butinchikak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butinchikak.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_84.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._084)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButBOUROUGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButBOUROUGE.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_85.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._086)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Buttarik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttarik.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_86.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._086)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butaanla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butaanla.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_87.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._087)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butfajr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butfajr.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_89.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._089)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butgachia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butgachia.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_88.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._088)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butbalad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butbalad.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_90.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._090)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butchams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butchams.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_91.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._091)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butlayle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butlayle.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_92.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._092)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butdouha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butdouha.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_93.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._093)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butcharh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcharh.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_94.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._094)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub tine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tine.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_95.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._095)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButANLAKE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButANLAKE.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_96.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._096)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButBAYINA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butkadari.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_97.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._097)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButZALZALAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butbayna.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_98.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._098)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butandiyati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butandiyati.Click

    End Sub

    Private Sub Butalkorian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butalandiya.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_100.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._100)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butalkoriya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butalkoriya.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_101.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._101)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Buttakathour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttakathour.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_102.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._102)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butansri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butansri.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_103.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._103)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub HOUMAZA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOUMAZA.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_104.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._104)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub butfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butfile.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_105.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._105)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButKOURAYCHI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButKOURAYCHI.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_106.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._106)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub ButMaoune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMaoune.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_107.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._107)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butkawthari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butkawthari.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_108.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._108)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butkafiroune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butkafiroune.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_109.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._109)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Buttonnasri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonnasri.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_110.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._110)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butmassadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butmassadi.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_111.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._111)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butikhlassi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butikhlassi.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_112.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._112)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Butfalaki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butfalaki.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_113.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._113)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Buttonnasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonnasi.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        f = Path.Combine(Application.StartupPath, "_114.mp3")
        If (Not File.Exists(f)) Then
            File.WriteAllBytes(f, My.Resources._114)
        End If
        c = 1
        jouer()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim envoi As New MailMessage
        Dim portutilise As New SmtpClient("smtp.gmail.com")
        envoi.From = New MailAddress(TextBox1.Text)
        envoi.To.Add("zakiyoubababodi@gmail.com")
        envoi.Subject = "Avis"
        envoi.Body = TextBox3.Text
        portutilise.Port = "587"
        portutilise.Credentials = New System.Net.NetworkCredential("zakiyoubababodi@gmail.com", TextBox2.Text)
        portutilise.EnableSsl = True
        portutilise.Send(envoi)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("www.facebook.com")
    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

        sp.Speak(RichTextBox1.Text)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub
End Class
