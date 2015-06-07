Imports Internet_Favorites

Public Class Viewer
    Private Sub Viewer_Load(sender As Object,
    e As EventArgs) Handles Me.Load

        Try
            'Create and use a new instance of the Favorites class
            Using objFavorites As New Favorites

                'Scan the Favorites folder
                objFavorites.ScanFavorites()

                'Process each objWebFavorite object in the
                'favorites collection
                For Each objWebFavorite As WebFavorite In
                    objFavorites.FavoritesCollection

                    'Declare a ListViewItem object
                    Dim objListViewItem As New ListViewItem

                    'Set the properties of the ListViewItem object
                    objListViewItem.Text = objWebFavorite.Name
                    objListViewItem.SubItems.Add(objWebFavorite.Url)

                    'Add the ListViewItem object to the ListView
                    lvwFavorites.Items.Add(objListViewItem)
                Next

            End Using
        Catch ExceptionErr As Exception
            'Display the error
            MessageBox.Show(ExceptionErr.Message, "Favorites Viewer",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lvwFavorites_Click(sender As Object,
        e As EventArgs) Handles lvwFavorites.Click

        'Update the link label control Text property
        lnkUrl.Text = "Visit " & lvwFavorites.SelectedItems.Item(0).Text

        'Clear the default hyperlink
        lnkUrl.Links.Clear()

        'Add the selected hyperlink to the LinkCollection
        lnkUrl.Links.Add(6, lvwFavorites.SelectedItems.Item(0).Text.Length,
            lvwFavorites.SelectedItems.Item(0).SubItems(1).Text)
    End Sub

    Private Sub lnkUrl_LinkClicked(sender As Object,
        e As LinkLabelLinkClickedEventArgs) Handles lnkUrl.LinkClicked

        'Process the selected link
        Process.Start(e.Link.LinkData)

    End Sub
End Class
