Public Class RPGitemEditor
    Public powerChoise(19) As ComboBox
    Public PanelPower(19) As Panel
    Public InfoText(300) As Label
    Public SelectOption(300) As ComboBox
    Public SelectValue(300) As NumericUpDown
    Public SelectPower(70, 20) As Boolean
    Dim power As String
    Dim k As Integer
    Dim j As Integer
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim Color As String = ""
        Dim random As New Random(), rnd(20) As Integer
        For i = 0 To 20
            rnd(i) = random.Next(0, 9)
        Next

        If Level.Text = "1 - 5" Or Level.Text = "6 - 10" Then
            Color = "&7&l"
        ElseIf Level.Text = "11 - 15" Or Level.Text = "16 - 20" Then
            Color = "&f&l"
        ElseIf Level.Text = "21 - 25" Or Level.Text = "26 - 30" Then
            Color = "&a&l"
        ElseIf Level.Text = "31 - 35" Or Level.Text = "36 - 40" Then
            Color = "&9&l"
        End If

        Dim monFichier As System.IO.StreamWriter
        'monFichier = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Jonathan\Desktop\" & ID.Text & "-item" & ".yml", False)
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            monFichier = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)

            monFichier.WriteLine("name: " & ID.Text)
            If CheckBox1.Checked = True Then
                monFichier.Write("uid: -")
                For i = 0 To 20
                    monFichier.Write("" & rnd(i))
                Next
            Else
                monFichier.Write("uid: -" & UID.Text)
            End If
            monFichier.WriteLine()
            monFichier.WriteLine("author: """ & Author.Text & """")
            monFichier.WriteLine("note: """ & Note.Text & """")
            monFichier.WriteLine("license: " & License.Text)
            monFichier.WriteLine("mcVersion: """ & MinecraftVersion.Text & """")
            monFichier.WriteLine("pluginSerial: " & PluginSerial.Text)
            monFichier.WriteLine("haspermission: " & HasPermission.Text)
            monFichier.WriteLine("permission: rpgitem.item." & ID.Text)
            monFichier.WriteLine("display: """ & Color & Display.Text & " (lvl " & Level.Text & ")""")
            monFichier.WriteLine("damageMin: " & DamageMin.Value)
            monFichier.WriteLine("damageMax: " & DamageMax.Value)
            monFichier.WriteLine("armour: " & Armour.Value)
            monFichier.WriteLine("type: " & Type.Text)
            monFichier.WriteLine("hand: " & Hand.Text)
            If DescriptionL1.Text IsNot "" Then
                monFichier.WriteLine("description:")
                monFichier.WriteLine("- """ & DescriptionL1.Lines.Count & """")
                If DescriptionL2.Text IsNot "" Then
                    monFichier.WriteLine("- """ & DescriptionL2.Text & """")
                    If DescriptionL3.Text IsNot "" Then
                        monFichier.WriteLine("- """ & DescriptionL3.Text & """")
                        If DescriptionL4.Text IsNot "" Then
                            monFichier.WriteLine("- """ & DescriptionL4.Text & """")
                            If DescriptionL5.Text IsNot "" Then
                                monFichier.WriteLine("- """ & DescriptionL5.Text & """")
                                If DescriptionL6.Text IsNot "" Then
                                    monFichier.WriteLine("- """ & DescriptionL6.Text & """")
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                monFichier.WriteLine("description: []")
            End If
            monFichier.WriteLine("item: " & Item.Text)
            monFichier.WriteLine("ignoreWorldGuard: " & IgnoreWorldGuard.Text)
            monFichier.WriteLine("item_data: " & ItemData.Value)
            If k = 0 Then
                monFichier.WriteLine("powers: {}")
            Else
                monFichier.WriteLine("powers:")
                For i = 0 To k - 1
                    If SelectPower(0, i) = True Then
                        power = "consume"
                    ElseIf SelectPower(1, i) = True Then
                        power = "criticalhit"
                    ElseIf SelectPower(2, i) = True Then
                        power = "headshot"
                    End If
                    monFichier.WriteLine("  '" & i & "':")
                    monFichier.WriteLine("    powerName: rpgitems:" & power)
                    If power = "consume" Then
                        monFichier.WriteLine("    requireHurtByEntity: " & SelectOption((i * 15) + 1).Text)
                        monFichier.WriteLine("    cost: " & SelectValue((i * 15)).Value)
                        monFichier.WriteLine("    cooldown: " & SelectValue((i * 15) + 1).Value)
                        If SelectOption((i * 15) + 2).Text = "" Then
                        Else
                            monFichier.WriteLine("    condition: " & SelectOption((i * 15) + 2).Text)
                        End If
                        monFichier.WriteLine("    triggers: " & SelectOption((i * 15)).Text)
                    ElseIf power = "criticalhit" Then
                        monFichier.WriteLine("    setBaseDamage: " & SelectOption((i * 15)).Text)
                        monFichier.WriteLine("    chance: " & SelectValue((i * 15)).Value & "." & SelectValue((i * 15) + 1).Value)
                        monFichier.WriteLine("    backstabChance: " & SelectValue((i * 15) + 2).Value & "." & SelectValue((i * 15) + 3).Value)
                        If SelectOption((i * 15) + 1).Text = "" Then
                        Else
                            monFichier.WriteLine("    condition: " & SelectOption((i * 15) + 1).Text)
                        End If
                        monFichier.WriteLine("    backstabFactor: " & SelectValue((i * 15) + 6).Value & "." & SelectValue((i * 15) + 7).Value)
                        monFichier.WriteLine("    factor: " & SelectValue((i * 15) + 4).Value & "." & SelectValue((i * 15) + 5).Value)
                    ElseIf power = "headshot" Then
                        monFichier.WriteLine("    setBaseDamage: " & SelectOption((i * 15) + 3).Text)
                        monFichier.WriteLine("    particleEnemy: " & SelectOption((i * 15)).Text)
                        monFichier.WriteLine("    cost: " & SelectValue((i * 15)).Value)
                        If SelectOption((i * 15) + 4).Text = "" Then
                        Else
                            monFichier.WriteLine("    condition: " & SelectOption((i * 15) + 4).Text)
                        End If
                        monFichier.WriteLine("    soundEnemy: " & SelectOption((i * 15) + 1).Text)
                        monFichier.WriteLine("    factor: " & SelectValue((i * 15) + 1).Value & "." & SelectValue((i * 15) + 2).Value)
                        monFichier.WriteLine("    soundSelf: " & SelectOption((i * 15) + 2).Text)
                    End If
                Next
            End If
            monFichier.WriteLine("recipechance: 0") ''NOT SUPPORTED
            monFichier.WriteLine("hasRecipe: false") ''NOT SUPPORTED 
            monFichier.WriteLine("dropChances: {}") ''NOT SUPPORTED
            monFichier.WriteLine("hitCost: " & HitCost.Value)
            monFichier.WriteLine("hittingCost: " & HittingCost.Value)
            monFichier.WriteLine("blockBreakingCost: " & BlockBreakingCost.Value)
            monFichier.WriteLine("hitCostByDamage: " & HitCostByDamage.Text)
            monFichier.WriteLine("maxDurability: " & Durability.Value)
            monFichier.WriteLine("defaultDurability: " & Durability.Value)
            monFichier.WriteLine("durabilityLowerBound: " & DurabilityLower.Value)
            monFichier.WriteLine("durabilityUpperBound: " & DurabilityUpper.Value)
            monFichier.WriteLine("forceBar: " & ForceBar.Text)
            monFichier.WriteLine("showPowerText: " & ShowPowerText.Text)
            monFichier.WriteLine("showArmourLore: " & ShowArmourLore.Text)
            monFichier.WriteLine("damageMode: " & DamageMode.Text)
            monFichier.WriteLine("customItemModel: false") ''NOT SUPPORTED 
            monFichier.WriteLine("numericBar: " & HasDurabilityBar.Text)
            monFichier.WriteLine("alwaysAllowMelee: " & AlwaysAllowMelee.Text)
            monFichier.Close()
            End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            UID.Visible = False
        Else
            UID.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As New Random, rng As Integer
        rng = rand.Next(10, 250 + 1) * 5
        Durability.Value = rng
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim ButtonPower As Button() = {ButtonPower1, ButtonPower2, ButtonPower3, ButtonPower4, ButtonPower5, ButtonPower6, ButtonPower7, ButtonPower8, ButtonPower9, ButtonPower10, ButtonPower11, ButtonPower12, ButtonPower13, ButtonPower14, ButtonPower15, ButtonPower16, ButtonPower17, ButtonPower18, ButtonPower19, ButtonPower20}
        For i = 0 To 19
            ButtonPower(i).Location = New Point(600 - (i * 250) + HScrollBar1.Value, 175)
            powerChoise(i).Location = New Point(ButtonPower(i).Location.X - 13, ButtonPower(i).Location.Y - 25)
            PanelPower(i).Location = New Point((ButtonPower(0).Location.X + 175) - (i * 250), 0)
        Next
    End Sub

    Private Sub ButtonPower1_Click(sender As Object, e As EventArgs) Handles ButtonPower1.Click, ButtonPower2.Click, ButtonPower3.Click, ButtonPower4.Click, ButtonPower5.Click, ButtonPower6.Click, ButtonPower7.Click, ButtonPower8.Click, ButtonPower9.Click, ButtonPower10.Click, ButtonPower11.Click, ButtonPower12.Click, ButtonPower13.Click, ButtonPower14.Click, ButtonPower15.Click, ButtonPower16.Click, ButtonPower17.Click, ButtonPower18.Click, ButtonPower19.Click, ButtonPower20.Click
        Dim ButtonPower As Button() = {ButtonPower1, ButtonPower2, ButtonPower3, ButtonPower4, ButtonPower5, ButtonPower6, ButtonPower7, ButtonPower8, ButtonPower9, ButtonPower10, ButtonPower11, ButtonPower12, ButtonPower13, ButtonPower14, ButtonPower15, ButtonPower16, ButtonPower17, ButtonPower18, ButtonPower19, ButtonPower20}
        Dim x = Array.IndexOf(ButtonPower, sender)
        If ButtonPower(x).Text = "Confirm" Then
            ButtonPower(x).Visible = False
            powerChoise(x).Visible = False
            If powerChoise(x).Text = ("Consume") Then
                ''STOCKAGE'' 
                SelectPower(0, k) = True
                '//////////'
                PowerPaint(0, x)
            ElseIf powerChoise(x).Text = ("CriticalHit") Then
                ''STOCKAGE'' 
                SelectPower(1, k) = True
                '//////////'
                PowerPaint(1, x)
            ElseIf powerChoise(x).Text = ("HeadShot") Then
                ''STOCKAGE'' 
                SelectPower(2, k) = True
                '//////////'
                PowerPaint(2, x)
            End If
        ElseIf k = x Then
            MenuPower.Controls.Add(powerChoise(x))
            powerChoise(x).Visible = True
            ButtonPower(x).Text = ("Confirm")
        End If
    End Sub

    Private Sub PowerPaint(power, X)
        j = k * 15
        k += 1
        Dim ButtonPower As Button() = {ButtonPower1, ButtonPower2, ButtonPower3, ButtonPower4, ButtonPower5, ButtonPower6, ButtonPower7, ButtonPower8, ButtonPower9, ButtonPower10, ButtonPower11, ButtonPower12, ButtonPower13, ButtonPower14, ButtonPower15, ButtonPower16, ButtonPower17, ButtonPower18, ButtonPower19, ButtonPower20}
        PanelPower(k).Location = New Point(ButtonPower(X).Location.X - 75, 0)
        PanelPower(k).Size = New Size(200, 450)
        PanelPower(k).BorderStyle = BorderStyle.Fixed3D
        ButtonPower(k).BackColor = Color.Green
        MenuPower.Controls.Add(PanelPower(k))
        Select Case power
            Case 0
                PanelPower(k).BackColor = Color.Red

                'OPTIONS'
                With InfoText(j)
                    .Parent = PanelPower(k)
                    .Text = ("Power: Consume")
                    .Size = New Size(Text.Length * 10, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Location = New Point((PanelPower(k).Size.Width / 2) - (InfoText(j).Size.Width / 2), 5)
                End With

                '0:1'
                With InfoText(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 55)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Cost:")
                End With
                With SelectValue(j)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 55)
                    .Value = 0
                    .Minimum = 0
                    .Maximum = 999999
                End With

                '0:2'
                With InfoText(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 80)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Cooldown (tick):")
                End With
                With SelectValue(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 80)
                    .Value = 0
                    .Minimum = 0
                    .Maximum = 999999
                End With

                '0:3'
                With InfoText(j + 3)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 115)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Triggers:")
                End With
                With SelectOption(j)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 115)
                    .Text = ("RIGHT_CLICK")
                    .Items.Add("RIGHT_CLICK")
                    .Items.Add("LEFT_CLICK")
                End With

                With InfoText(j + 4)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 140)
                    .Size = New Size(65, 45)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Require Hurt By Entity:")
                End With
                With SelectOption(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 140)
                    .Text = ("false")
                    .Items.Add("true")
                    .Items.Add("false")
                End With

                '0:4'
                With InfoText(j + 5)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 190)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Condition:")
                End With
                With SelectOption(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 190)
                End With
                'END OPTIONS'

            Case 1
                PanelPower(k).BackColor = Color.Blue

                'OPTIONS'
                '1:0'
                With InfoText(j)
                    .Parent = PanelPower(k)
                    .Size = New Size(100, 30)
                    .Location = New Point((PanelPower(k).Size.Width / 2) - (InfoText(j).Size.Width / 2), 5)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Power: Critical Hit and Backstab")
                End With

                '1:1'
                With InfoText(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 55)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("CritChance (Int,Des):")
                End With
                With SelectValue(j)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 55)
                    .Size = New Point(50, DefaultSize.Height)
                    .Value = 20
                    .Maximum = 99999
                    .Minimum = 0
                End With
                With SelectValue(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(132, 55)
                    .Size = New Point(50, DefaultSize.Height)
                    .Value = 0
                    .Maximum = 99
                    .Minimum = 0
                End With

                '1:2'
                With InfoText(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 90)
                    .Size = New Size(65, 45)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("BackStab Chance (Int, Des):")
                End With
                With SelectValue(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 90)
                    .Size = New Point(50, DefaultSize.Height)
                    .Value = 20
                    .Maximum = 99999
                    .Minimum = 0
                End With
                With SelectValue(j + 3)
                    .Parent = PanelPower(k)
                    .Location = New Point(132, 90)
                    .Size = New Point(50, DefaultSize.Height)
                    .Value = 0
                    .Maximum = 99
                    .Minimum = 0
                End With

                '1:3'
                With InfoText(j + 3)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 140)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("CritFactor (Int,Des):")
                End With
                With SelectValue(j + 4)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 140)
                    .Size = New Size(50, DefaultSize.Height)
                    .Value = 1
                    .Maximum = 99999
                    .Minimum = 0
                End With
                With SelectValue(j + 5)
                    .Parent = PanelPower(k)
                    .Location = New Point(132, 140)
                    .Size = New Size(50, DefaultSize.Height)
                    .Value = 5
                    .Maximum = 99
                    .Minimum = 0
                End With

                '1:4'
                With InfoText(j + 4)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 175)
                    .Size = New Size(65, 45)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("BackStab Factor (Int,Des):")
                End With
                With SelectValue(j + 6)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 175)
                    .Size = New Size(50, DefaultSize.Height)
                    .Value = 1
                    .Maximum = 99999
                    .Minimum = 0
                End With
                With SelectValue(j + 7)
                    .Parent = PanelPower(k)
                    .Location = New Point(132, 175)
                    .Size = New Size(50, DefaultSize.Height)
                    .Value = 5
                    .Maximum = 99
                    .Minimum = 0
                End With

                '1:5'
                With InfoText(j + 5)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 225)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("SetBase Damage:")
                End With
                With SelectOption(j)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 225)
                    .Text = "false"
                    .Items.Add("true")
                    .Items.Add("false")
                End With

                '1:6'
                With InfoText(j + 6)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 260)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Condition:")
                End With
                With SelectOption(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 260)
                End With
                'END OPTIONS'

            Case 2
                PanelPower(k).BackColor = Color.Green

                'OPTIONS'
                '2:0
                With InfoText(j)
                    .Parent = PanelPower(k)
                    .Text = ("Power: HeadShot")
                    .Size = New Size(Text.Length * 10, 20)
                    .Location = New Point((PanelPower(k).Size.Width / 2) - (InfoText(j).Size.Width / 2), 5)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                End With

                '2:1'
                With InfoText(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 55)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Cost:")
                End With
                With SelectValue(j)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 55)
                    .Value = 1
                    .Minimum = 0
                End With

                '2:2'
                With InfoText(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 80)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Particle Enemy:")
                End With
                With SelectOption(j)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 80)
                    .Text = "true"
                    .Items.Add("true")
                    .Items.Add("false")
                End With

                '2:3'
                With InfoText(j + 3)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 115)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Factor (Int,Des):")
                End With
                With SelectValue(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 115)
                    .Size = New Size(50, DefaultSize.Height)
                    .Value = 1
                    .Minimum = 0
                    .Maximum = 99999
                End With
                With SelectValue(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(132, 115)
                    .Size = New Size(50, DefaultSize.Height)
                    .Value = 5
                    .Minimum = 0
                    .Maximum = 99
                End With

                '2:4'
                With InfoText(j + 4)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 150)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Sound Enemy:")
                End With
                With SelectOption(j + 1)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 150)
                    .Text = "false"
                    .Items.Add("true")
                    .Items.Add("false")
                End With

                '2:5'
                With InfoText(j + 5)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 185)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("SoundSelf:")
                End With
                With SelectOption(j + 2)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 185)
                    .Text = "false"
                    .Items.Add("true")
                    .Items.Add("false")
                End With

                '2:6'
                With InfoText(j + 6)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 210)
                    .Size = New Size(65, 30)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("SetBase Damage:")
                End With
                With SelectOption(j + 3)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 210)
                    .Text = "false"
                    .Items.Add("true")
                    .Items.Add("false")
                End With

                '2:7'
                With InfoText(j + 7)
                    .Parent = PanelPower(k)
                    .Location = New Point(5, 245)
                    .Size = New Size(65, 20)
                    .BackColor = Color.White
                    .BorderStyle = BorderStyle.Fixed3D
                    .Text = ("Condition:")
                End With
                With SelectOption(j + 4)
                    .Parent = PanelPower(k)
                    .Location = New Point(72, 245)
                End With
                'END OPTIONS'
        End Select
        If k > 0 Then
            RemovePower.Parent = PanelPower(k)
            RemovePower.Location = New Point((PanelPower(k).Size.Width / 2) - (RemovePower.Size.Width / 2), PanelPower(k).Size.Height - RemovePower.Size.Height - 25)
        End If
    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Dim ButtonPower As Button() = {ButtonPower1, ButtonPower2, ButtonPower3, ButtonPower4, ButtonPower5, ButtonPower6, ButtonPower7, ButtonPower8, ButtonPower9, ButtonPower10, ButtonPower11, ButtonPower12, ButtonPower13, ButtonPower14, ButtonPower15, ButtonPower16, ButtonPower17, ButtonPower18, ButtonPower19, ButtonPower20}
        ButtonPower(k).BackColor = Color.Green
        HScrollBar1.Value = 0
        For i = 0 To 19
            ButtonPower(i).Location = New Point(600 - (i * 250), 175)
            PanelPower(i).Location = New Point((ButtonPower(0).Location.X + 175) - (i * 250), 0)
            ButtonPower(i).Text = ("NEW POWER")
            If TabControl1.SelectedTab Is Powers Then
                powerChoise(i) = New ComboBox
                powerChoise(i).Size = New Size(100, 20)
                powerChoise(i).Text = ("HeadShot")
                powerChoise(i).Items.Add("HeadShot")
                powerChoise(i).Items.Add("Consume")
                powerChoise(i).Items.Add("CriticalHit")
                powerChoise(i).Location = New Point(ButtonPower(i).Location.X - 13, ButtonPower(i).Location.Y - 25)
            Else
                MenuPower.Controls.Remove(powerChoise(i))
            End If
        Next
    End Sub

    Private Sub RPGitemEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemovePower.Location = New Point(-100, -100)
        For x = 0 To 19
            PanelPower(x) = New Panel
        Next
        For x = 0 To 300
            SelectOption(x) = New ComboBox
            SelectValue(x) = New NumericUpDown
            InfoText(x) = New Label
        Next
    End Sub

    Private Sub RemovePower_Click(sender As Object, e As EventArgs) Handles RemovePower.Click
        'Dim ButtonPower As Button() = {ButtonPower1, ButtonPower2, ButtonPower3, ButtonPower4, ButtonPower5, ButtonPower6, ButtonPower7, ButtonPower8, ButtonPower9, ButtonPower10, ButtonPower11, ButtonPower12, ButtonPower13, ButtonPower14, ButtonPower15, ButtonPower16, ButtonPower17, ButtonPower18, ButtonPower19, ButtonPower20}
        'PanelPower(k).Location = New Point(0, 0)
        'PanelPower(k).Size = New Size(0, 0)
        'ButtonPower(k).BackColor = Color.Red
        'MenuPower.Controls.Add(PanelPower(k))
        'k -= 1
        'ButtonPower(k).Visible = True
        'ButtonPower(k).Text = "NEW POWER"
    End Sub
End Class
