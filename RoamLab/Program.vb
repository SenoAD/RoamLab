Imports System
Imports RoamLab.DAL
Imports RoamLab.BO

Module Program
    Sub Main()
        Dim placeData As New Category
        placeData.Name = "Accommodation"
        placeData.Description = "Place to temporary stay the night tes"
        placeData.CategoryID = 1


        Dim placeSP As New RoamLab.DAL.CategoryDAL

        placeSP.Update(placeData)


    End Sub
End Module
