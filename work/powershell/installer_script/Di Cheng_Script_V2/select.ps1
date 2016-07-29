

function button ($title,$mailbx, $WF, $TF) {

###################Load Assembly for creating form & button######

[void][System.Reflection.Assembly]::LoadWithPartialName( "System.Windows.Forms")
[void][System.Reflection.Assembly]::LoadWithPartialName( "Microsoft.VisualBasic")

#####Define the form size & placement
$form = New-Object "System.Windows.Forms.Form";
$form.Width = 500;
$form.Height = 250;
$form.Text = $title;
$form.StartPosition = [System.Windows.Forms.FormStartPosition]::CenterScreen;

##############Define text label1
$textLabel1 = New-Object "System.Windows.Forms.Label";
$textLabel1.Left = 25;
$textLabel1.Top = 15;
$textLabel1.Height = 40;
$textLabel1.Text = $mailbx;

##############Define text label2

$textLabel2 = New-Object "System.Windows.Forms.Label";
$textLabel2.Left = 25;
$textLabel2.Top = 60;
$textLabel2.Height = 40;
$textLabel2.Text = $WF;

##############Define text label3

$textLabel3 = New-Object "System.Windows.Forms.Label" ;
$textLabel3.Left = 25;
$textLabel3.Top = 110;
$textLabel3.Height = 40;
$textLabel3.Text = $TF;

############Define text box1 for input
$textBox1 = New-Object "System.Windows.Forms.TextBox";
$textBox1.Left = 150;
$textBox1.Top = 20;
$textBox1.width = 200;

############Define text box2 for input

$textBox2 = New-Object "System.Windows.Forms.TextBox";
$textBox2.Left = 150;
$textBox2.Top = 70;
$textBox2.width = 200;

############Define text box3 for input

$textBox3 = New-Object System.Windows.Forms.MaskedTextBox;
$textBox3.PasswordChar = '*'
$textBox3.Left = 150;
$textBox3.Top = 120;
$textBox3.width = 200;




#############Define default values for the input boxes
$defaultValue = ""
$textBox1.Text = $defaultValue;
$textBox2.Text = $defaultValue;
$textBox3.Text = $defaultValue;

#############define OK button
$button = New-Object "System.Windows.Forms.Button";
$button.Left = 360;
$button.Top = 145;
$button.Width = 100;
$button.Text = "Ok";

############# This is when you have to close the form after getting values
$eventHandler = [System.EventHandler]{
$textBox1.Text;
$textBox2.Text;
$textBox3.Text;
$form.Close();};

$button.Add_Click($eventHandler) ;

#############Add controls to all the above objects defined
$form.Controls.Add($button);
$form.Controls.Add($textLabel1);
$form.Controls.Add($textLabel2);
$form.Controls.Add($textLabel3);
$form.Controls.Add($textBox1);
$form.Controls.Add($textBox2);
$form.Controls.Add($textBox3);
$ret = $form.ShowDialog();

#################return values

return $textBox1.Text, $textBox2.Text, $textBox3.Text
}

$return= button "Enter Info" "Computer Name (e.g. chh001):" "Domain Admin Account username (e.g. jsmith):" "Domain Admin Account Password:"

#################mkdir
$return[0] = "\\"+$return[0] 
$return[1] = "chh\"+ $return[1]

$env:Computer = $return[0]
$env:Username = $return[1]
$env:Password = $return[2]
& ".\/mkdir.bat"



$x = @()

[void] [System.Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms")
[void] [System.Reflection.Assembly]::LoadWithPartialName("System.Drawing") 

$objForm = New-Object System.Windows.Forms.Form 
$objForm.Text = "Data Entry Form"
$objForm.Size = New-Object System.Drawing.Size(300,200) 
$objForm.StartPosition = "CenterScreen"

$objForm.KeyPreview = $True

$objForm.Add_KeyDown({if ($_.KeyCode -eq "Enter") 
    {
        foreach ($objItem in $objListbox.SelectedItems)
            {$x += $objItem}
        $objForm.Close()
    }
    })

$objForm.Add_KeyDown({if ($_.KeyCode -eq "Escape") 
    {$objForm.Close()}})

$OKButton = New-Object System.Windows.Forms.Button
$OKButton.Location = New-Object System.Drawing.Size(75,120)
$OKButton.Size = New-Object System.Drawing.Size(75,23)
$OKButton.Text = "OK"

$OKButton.Add_Click(
   {
        foreach ($objItem in $objListbox.SelectedItems)
            {$x += $objItem}
        $objForm.Close()
   })

$objForm.Controls.Add($OKButton)

$CancelButton = New-Object System.Windows.Forms.Button
$CancelButton.Location = New-Object System.Drawing.Size(150,120)
$CancelButton.Size = New-Object System.Drawing.Size(75,23)
$CancelButton.Text = "Cancel"
$CancelButton.Add_Click({$objForm.Close()})
$objForm.Controls.Add($CancelButton)

$objLabel = New-Object System.Windows.Forms.Label
$objLabel.Location = New-Object System.Drawing.Size(10,20) 
$objLabel.Size = New-Object System.Drawing.Size(280,20) 
$objLabel.Text = "Please make a selection from the list below:"
$objForm.Controls.Add($objLabel) 

$objListbox = New-Object System.Windows.Forms.Listbox 
$objListbox.Location = New-Object System.Drawing.Size(10,40) 
$objListbox.Size = New-Object System.Drawing.Size(260,20) 

$objListbox.SelectionMode = "MultiExtended"

[void] $objListbox.Items.Add("SAGITTA")
[void] $objListbox.Items.Add("ImageRight")
[void] $objListbox.Items.Add("Office 2010")
[void] $objListbox.Items.Add("McAffee Agent")
[void] $objListbox.Items.Add("IE 9")

$objListbox.Height = 70
$objForm.Controls.Add($objListbox) 
$objForm.Topmost = $True

$objForm.Add_Shown({$objForm.Activate()})
[void] $objForm.ShowDialog()


for ($i=0; $i -lt $x.length; $i++) {
    Switch($x[$i]){
        "SAGITTA"{
            &".\/sagitta.bat" $return[0] $return[1] $return[2]
        }
        "ImageRIght"{
            & ".\/ImageRight.bat" $return[0] $return[1] $return[2]
        }
        "Office 2010"{
            & ".\/Office2010.bat" $return[0] $return[1] $return[2]
        }
        "McAffee Agent"{
            & ".\/McAffeeAgent.bat" $return[0] $return[1] $return[2]
        }
        "IE 9"{
            & ".\/IE9.bat" $return[0] $return[1] $return[2]
        }
    }
}

#& ".\/pass.bat" $return[0] $x[1] $x[0]

#& ".\/pass.bat" $return[1] $x[0]
#& "C:\Users\di\Desktop\autointall.bat" $x