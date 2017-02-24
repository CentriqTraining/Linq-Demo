        Dim emps As New List(Of Employee)() From
           {
               New Employee() With {.FirstName = "Mike", .LastName = "Rissen", .ID = 1},
               New Employee() With {.FirstName = "Fred", .LastName = "Flinstone", .ID = 2},
               New Employee() With {.FirstName = "Wilma", .LastName = "Flinstone", .ID = 3},
               New Employee() With {.FirstName = "Barney", .LastName = "Rubble", .ID = 4},
               New Employee() With {.FirstName = "Betty", .LastName = "Rubble", .ID = 5}
           }

        Dim fs1 As New FileStream("C:\users\student\desktop\file-xml.xml", FileMode.Create)
        Dim fs2 As New FileStream("C:\users\student\desktop\file-bin.xml", FileMode.Create)
        Dim fs3 As New FileStream("C:\users\student\desktop\file-soap.xml", FileMode.Create)
        Dim fs4 As New FileStream("C:\users\student\desktop\file-json.xml", FileMode.Create)

        Dim xml As XmlSerializer = New XmlSerializer(emps.GetType())
        Dim bin As BinaryFormatter = New BinaryFormatter()
        Dim soap As SoapFormatter = New SoapFormatter()
        Dim json As DataContractJsonSerializer = New DataContractJsonSerializer(emps.GetType())

        xml.Serialize(fs1, emps)
        bin.Serialize(fs2, emps)
        soap.Serialize(fs3, emps.ToArray())
        json.WriteObject(fs4, emps)

        fs1.Close()
        fs2.Close()
        fs3.Close()
        fs4.Close()

        Dim newvalues As List(Of Employee) = Nothing

        fs1 = New FileStream("C:\users\student\desktop\file-xml.xml", FileMode.Open)
        newvalues = CType(xml.Deserialize(fs1), List(Of Employee))
