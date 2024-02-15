Imports System.Configuration
Imports MySql.Data.MySqlClient

Namespace DataAccessLayer
    Public Class Personnel

#Region "Fields"
        Private _ID As Integer
        Private _FirstName As String
        Private _LastName As String
        Private _MilitaryUnitStructureID As Integer?
        Private _BirthDate As Date?
        Private _BloodTypesID As Integer?
        Private _IdentityCard As String
        Private _MilitaryCard As String
        Private _FatherName As String
        Private _MotherName As String
        Private _Profession As String
        Private _ImageFileName As String
#End Region

#Region "Properties"
        Friend Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property

        Friend Property FirstName() As String
            Get
                Return _FirstName
            End Get
            Set(value As String)
                _FirstName = value
            End Set
        End Property

        Friend Property LastName() As String
            Get
                Return _LastName
            End Get
            Set(value As String)
                _LastName = value
            End Set
        End Property

        Friend Property MilitaryUnitStructureID() As Integer?
            Get
                Return _MilitaryUnitStructureID
            End Get
            Set(value As Integer?)
                _MilitaryUnitStructureID = value
            End Set
        End Property

        Friend Property BirthDate() As Date?
            Get
                Return _BirthDate
            End Get
            Set(value As Date?)
                _BirthDate = value
            End Set
        End Property

        Friend Property BloodTypesID() As Integer?
            Get
                Return _BloodTypesID
            End Get
            Set(value As Integer?)
                _BloodTypesID = value
            End Set
        End Property

        Friend Property IdentityCard() As String
            Get
                Return _IdentityCard
            End Get
            Set(value As String)
                _IdentityCard = value
            End Set
        End Property

        Friend Property MilitaryCard() As String
            Get
                Return _MilitaryCard
            End Get
            Set(value As String)
                _MilitaryCard = value
            End Set
        End Property

        Friend Property FatherName() As String
            Get
                Return _FatherName
            End Get
            Set(value As String)
                _FatherName = value
            End Set
        End Property

        Friend Property MotherName() As String
            Get
                Return _MotherName
            End Get
            Set(value As String)
                _MotherName = value
            End Set
        End Property

        Friend Property Profession() As String
            Get
                Return _Profession
            End Get
            Set(value As String)
                _Profession = value
            End Set
        End Property

        Friend Property ImageFileName() As String
            Get
                Return _ImageFileName
            End Get
            Set(value As String)
                _ImageFileName = value
            End Set
        End Property
#End Region

#Region "CRUD"
        Friend Sub Add()
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ConnectionString

                Using con = New MySqlConnection(connectionString)
                    Dim query As String = "INSERT INTO `Personnel` " &
                        "(`FirstName`,`LastName`,`MilitaryUnitStructureID`,`BirthDate`,`BloodTypesID`,`IdentityCard`,`MilitaryCard`,`FatherName`,`MotherName`,`Profession`,`ImageFileName`) " &
                        "VALUES(@FirstName,@LastName,@MilitaryUnitStructureID,@BirthDate,@BloodTypesID,@IdentityCard,@MilitaryCard,@FatherName,@MotherName,@Profession,@ImageFileName);"

                    con.Open()

                    Using cmd = New MySqlCommand(query, con)
                        cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 32).Value = FirstName
                        cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 64).Value = LastName
                        cmd.Parameters.Add("@MilitaryUnitStructureID", MySqlDbType.Int32, 4).Value = If(IsNothing(MilitaryUnitStructureID), DBNull.Value, MilitaryUnitStructureID)
                        cmd.Parameters.Add("@BirthDate", MySqlDbType.Date, 3).Value = If(IsNothing(BirthDate), DBNull.Value, BirthDate)
                        cmd.Parameters.Add("@BloodTypesID", MySqlDbType.Int32, 4).Value = If(IsNothing(BloodTypesID), DBNull.Value, BloodTypesID)
                        cmd.Parameters.Add("@IdentityCard", MySqlDbType.VarChar, 16).Value = IdentityCard
                        cmd.Parameters.Add("@MilitaryCard", MySqlDbType.VarChar, 32).Value = MilitaryCard
                        cmd.Parameters.Add("@FatherName", MySqlDbType.VarChar, 32).Value = If(IsNothing(FatherName), DBNull.Value, FatherName)
                        cmd.Parameters.Add("@MotherName", MySqlDbType.VarChar, 32).Value = If(IsNothing(MotherName), DBNull.Value, MotherName)
                        cmd.Parameters.Add("@Profession", MySqlDbType.VarChar, 64).Value = If(IsNothing(Profession), DBNull.Value, Profession)
                        cmd.Parameters.Add("@ImageFileName", MySqlDbType.VarChar, 64).Value = If(IsNothing(ImageFileName), DBNull.Value, ImageFileName)
                        cmd.ExecuteNonQuery()

                        ID = Convert.ToInt32(cmd.LastInsertedId)
                    End Using

                    con.Close()
                End Using
            Catch ex As Exception

            End Try
        End Sub

        Friend Sub Update()
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ConnectionString

                Using con = New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE `Personnel` " &
                        "SET `FirstName`=@FirstName,`LastName`=@LastName,`MilitaryUnitStructureID`=@MilitaryUnitStructureID,`BirthDate`=@BirthDate,`BloodTypesID`=@BloodTypesID,`IdentityCard`=@IdentityCard,`MilitaryCard`=@MilitaryCard,`FatherName`=@FatherName,`MotherName`=@MotherName,`Profession`=@Profession,`ImageFileName`=@ImageFileName " &
                        "WHERE `ID`=@ID;"

                    con.Open()

                    Using cmd = New MySqlCommand(query, con)
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32, 4).Value = ID
                        cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 32).Value = FirstName
                        cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 64).Value = LastName
                        cmd.Parameters.Add("@MilitaryUnitStructureID", MySqlDbType.Int32, 4).Value = If(IsNothing(MilitaryUnitStructureID), DBNull.Value, MilitaryUnitStructureID)
                        cmd.Parameters.Add("@BirthDate", MySqlDbType.Date, 3).Value = If(IsNothing(BirthDate), DBNull.Value, BirthDate)
                        cmd.Parameters.Add("@BloodTypesID", MySqlDbType.Int32, 4).Value = If(IsNothing(BloodTypesID), DBNull.Value, BloodTypesID)
                        cmd.Parameters.Add("@IdentityCard", MySqlDbType.VarChar, 16).Value = IdentityCard
                        cmd.Parameters.Add("@MilitaryCard", MySqlDbType.VarChar, 32).Value = MilitaryCard
                        cmd.Parameters.Add("@FatherName", MySqlDbType.VarChar, 32).Value = If(IsNothing(FatherName), DBNull.Value, FatherName)
                        cmd.Parameters.Add("@MotherName", MySqlDbType.VarChar, 32).Value = If(IsNothing(MotherName), DBNull.Value, MotherName)
                        cmd.Parameters.Add("@Profession", MySqlDbType.VarChar, 64).Value = If(IsNothing(Profession), DBNull.Value, Profession)
                        cmd.Parameters.Add("@ImageFileName", MySqlDbType.VarChar, 64).Value = If(IsNothing(ImageFileName), DBNull.Value, ImageFileName)
                        cmd.ExecuteNonQuery()
                    End Using

                    con.Close()
                End Using
            Catch ex As Exception

            End Try
        End Sub

        Friend Shared Sub Delete(ByVal id As Integer)
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ConnectionString

                Using con = New MySqlConnection(connectionString)
                    Dim query As String = "DELETE FROM `Personnel` " &
                        "WHERE `ID`=@ID"

                    con.Open()

                    Using cmd = New MySqlCommand(query, con)
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32, 4).Value = id
                        cmd.ExecuteNonQuery()
                    End Using

                    con.Close()
                End Using
            Catch ex As Exception

            End Try
        End Sub

        Friend Shared Function GetSingle(ByVal id As Integer) As Personnel
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ConnectionString

                Using con = New MySqlConnection(connectionString)
                    Dim query As String = "SELECT `FirstName`,`LastName`,`MilitaryUnitStructureID`,`BirthDate`,`BloodTypesID`,`IdentityCard`,`MilitaryCard`,`FatherName`,`MotherName`,`Profession`,`ImageFileName` " &
                        "FROM `Personnel` " &
                        "WHERE `ID`=@ID"
                    Dim obj As New Personnel

                    con.Open()

                    Using cmd = New MySqlCommand(query, con)
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32, 4).Value = id

                        Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                            If reader.Read() Then
                                obj.ID = Convert.ToInt32(reader("ID"))
                                obj.FirstName = reader("FirstName").ToString
                                obj.LastName = reader("LastName").ToString
                                obj.MilitaryUnitStructureID = If(IsDBNull(reader("MilitaryUnitStructureID")), DirectCast(Nothing, Nullable(Of Integer)), Convert.ToInt32(reader("MilitaryUnitStructureID")))
                                obj.BirthDate = If(IsDBNull(reader("BirthDate")), DirectCast(Nothing, Nullable(Of DateTime)), Convert.ToDateTime(reader("BirthDate")))
                                obj.BloodTypesID = If(IsDBNull(reader("BloodTypesID")), DirectCast(Nothing, Nullable(Of Integer)), Convert.ToInt32(reader("BloodTypesID")))
                                obj.IdentityCard = reader("IdentityCard").ToString
                                obj.MilitaryCard = reader("MilitaryCard").ToString
                                obj.FatherName = If(IsDBNull(reader("FatherName")), Nothing, reader("FatherName").ToString)
                                obj.MotherName = If(IsDBNull(reader("MotherName")), Nothing, reader("MotherName").ToString)
                                obj.Profession = If(IsDBNull(reader("Profession")), Nothing, reader("Profession").ToString)
                                obj.ImageFileName = If(IsDBNull(reader("ImageFileName")), Nothing, reader("ImageFileName").ToString)
                            End If
                        End Using
                    End Using

                    Return obj
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Friend Shared Function GetAll(ByVal firstName As String, ByVal lasttName As String, ByVal identityCard As String, ByVal militaryCard As String) As List(Of Personnel)
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ConnectionString

                Using con = New MySqlConnection(connectionString)
                    Dim res As New List(Of Personnel)
                    Dim dataTable As New DataTable
                    Dim query As String = "SELECT `FirstName`,`LastName`,`MilitaryUnitStructureID`,`BirthDate`,`BloodTypesID`,`IdentityCard`,`MilitaryCard`,`FatherName`,`MotherName`,`Profession`,`ImageFileName` " &
                        "FROM `Personnel` " &
                        "WHERE (@FirstName IS NULL OR `FirstName` LIKE @FirstName) " &
                        "AND (@LastName IS NULL OR `LastName` LIKE @LastName) " &
                        "AND (@IdentityCard IS NULL OR `IdentityCard` LIKE @IdentityCard) " &
                        "AND (@MilitaryCard IS NULL OR `MilitaryCard` LIKE @MilitaryCard)"

                    con.Open()

                    Using cmd = New MySqlCommand(query, con)
                        cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 32).Value = If(String.IsNullOrEmpty(firstName), DBNull.Value, firstName)
                        cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 64).Value = If(String.IsNullOrEmpty(lasttName), DBNull.Value, lasttName)
                        cmd.Parameters.Add("@IdentityCard", MySqlDbType.VarChar, 16).Value = If(String.IsNullOrEmpty(identityCard), DBNull.Value, identityCard)
                        cmd.Parameters.Add("@MilitaryCard", MySqlDbType.VarChar, 32).Value = If(String.IsNullOrEmpty(militaryCard), DBNull.Value, militaryCard)

                        Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                            dataTable.Load(reader)
                            res = (From dr In dataTable.Rows
                                   Select New Personnel() With {
                                       .ID = Convert.ToInt32(dr("ID")),
                                       .FirstName = dr("FirstName").ToString,
                                       .LastName = dr("LastName").ToString,
                                       .MilitaryUnitStructureID = If(IsDBNull(dr("MilitaryUnitStructureID")), DirectCast(Nothing, Nullable(Of Integer)), Convert.ToInt32(dr("MilitaryUnitStructureID"))),
                                       .BirthDate = If(IsDBNull(dr("BirthDate")), DirectCast(Nothing, Nullable(Of DateTime)), Convert.ToDateTime(dr("BirthDate"))),
                                       .BloodTypesID = If(IsDBNull(dr("BloodTypesID")), DirectCast(Nothing, Nullable(Of Integer)), Convert.ToInt32(dr("BloodTypesID"))),
                                       .IdentityCard = dr("IdentityCard").ToString,
                                       .MilitaryCard = dr("MilitaryCard").ToString,
                                       .FatherName = If(IsDBNull(dr("FatherName")), Nothing, dr("FatherName").ToString),
                                       .MotherName = If(IsDBNull(dr("MotherName")), Nothing, dr("MotherName").ToString),
                                       .Profession = If(IsDBNull(dr("Profession")), Nothing, dr("Profession").ToString),
                                       .ImageFileName = If(IsDBNull(dr("ImageFileName")), Nothing, dr("ImageFileName").ToString)
                                    })

                        End Using
                    End Using

                    Return res
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
#End Region

#Region "Strongly-Typed Access To Property Names (for .NET databinding, etc.)"
        Friend Class PropertyNames
            Public Shared ReadOnly ID As String = "ID"
            Public Shared ReadOnly FirstName As String = "FirstName"
            Public Shared ReadOnly LastName As String = "LastName"
            Public Shared ReadOnly MilitaryUnitStructureID As String = "MilitaryUnitStructureID"
            Public Shared ReadOnly BirthDate As String = "BirthDate"
            Public Shared ReadOnly BloodTypesID As String = "BloodTypesID"
            Public Shared ReadOnly IdentityCard As String = "IdentityCard"
            Public Shared ReadOnly MilitaryCard As String = "MilitaryCard"
            Public Shared ReadOnly FatherName As String = "FatherName"
            Public Shared ReadOnly MotherName As String = "MotherName"
            Public Shared ReadOnly Profession As String = "Profession"
            Public Shared ReadOnly ImageFileName As String = "ImageFileName"
        End Class
#End Region

    End Class
End Namespace
