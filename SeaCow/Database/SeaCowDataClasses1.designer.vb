﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="SeaCowDatabase")>  _
Partial Public Class SeaCowDataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.SeacowOrganizer.My.MySettings.Default.SeaCowDatabaseConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Tasks() As System.Data.Linq.Table(Of Task)
		Get
			Return Me.GetTable(Of Task)
		End Get
	End Property
	
	Public ReadOnly Property Contacts() As System.Data.Linq.Table(Of Contact)
		Get
			Return Me.GetTable(Of Contact)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Tasks")>  _
Partial Public Class Task
	
	Private _name As String
	
	Private _description As String
	
	Private _priority As String
	
	Private _time As Date
	
	Private _status As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_name", DbType:="Text NOT NULL", CanBeNull:=false, UpdateCheck:=UpdateCheck.Never)>  _
	Public Property name() As String
		Get
			Return Me._name
		End Get
		Set
			If (String.Equals(Me._name, value) = false) Then
				Me._name = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_description", DbType:="Text", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property description() As String
		Get
			Return Me._description
		End Get
		Set
			If (String.Equals(Me._description, value) = false) Then
				Me._description = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_priority", DbType:="Text", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property priority() As String
		Get
			Return Me._priority
		End Get
		Set
			If (String.Equals(Me._priority, value) = false) Then
				Me._priority = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_time", DbType:="DateTime NOT NULL")>  _
	Public Property time() As Date
		Get
			Return Me._time
		End Get
		Set
			If ((Me._time = value)  _
						= false) Then
				Me._time = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_status", DbType:="Text", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property status() As String
		Get
			Return Me._status
		End Get
		Set
			If (String.Equals(Me._status, value) = false) Then
				Me._status = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Contacts")>  _
Partial Public Class Contact
	
	Private _FirstName As String
	
	Private _LastName As String
	
	Private _DisplayName As String
	
	Private _Nickname As String
	
	Private _PrimaryEmail As String
	
	Private _SecondaryEmail As String
	
	Private _ScreenName As String
	
	Private _WorkPhone As String
	
	Private _HomePhone As String
	
	Private _FaxNumber As String
	
	Private _PagerNumber As String
	
	Private _MobileNumber As String
	
	Private _HomeAddress As String
	
	Private _HomeAddress2 As String
	
	Private _HomeCity As String
	
	Private _HomeState As String
	
	Private _HomeZipCode As String
	
	Private _HomeCountry As String
	
	Private _WorkAddress As String
	
	Private _WorkAddress2 As String
	
	Private _WorkCity As String
	
	Private _WorkState As String
	
	Private _WorkZipCode As String
	
	Private _WorkCountry As String
	
	Private _JobTitle As String
	
	Private _Department As String
	
	Private _Organization As String
	
	Private _WebPage1 As String
	
	Private _WebPage2 As String
	
	Private _BirthYear As String
	
	Private _BirthMonth As String
	
	Private _BirthDay As String
	
	Private _Groups As String
	
	Private _Gender As String
	
	Private _Picture As String
	
	Private _Custom4 As String
	
	Private _Notes As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FirstName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstName() As String
		Get
			Return Me._FirstName
		End Get
		Set
			If (String.Equals(Me._FirstName, value) = false) Then
				Me._FirstName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property LastName() As String
		Get
			Return Me._LastName
		End Get
		Set
			If (String.Equals(Me._LastName, value) = false) Then
				Me._LastName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DisplayName", DbType:="NVarChar(50)")>  _
	Public Property DisplayName() As String
		Get
			Return Me._DisplayName
		End Get
		Set
			If (String.Equals(Me._DisplayName, value) = false) Then
				Me._DisplayName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Nickname", DbType:="NVarChar(50)")>  _
	Public Property Nickname() As String
		Get
			Return Me._Nickname
		End Get
		Set
			If (String.Equals(Me._Nickname, value) = false) Then
				Me._Nickname = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PrimaryEmail", DbType:="NVarChar(50)")>  _
	Public Property PrimaryEmail() As String
		Get
			Return Me._PrimaryEmail
		End Get
		Set
			If (String.Equals(Me._PrimaryEmail, value) = false) Then
				Me._PrimaryEmail = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SecondaryEmail", DbType:="NVarChar(50)")>  _
	Public Property SecondaryEmail() As String
		Get
			Return Me._SecondaryEmail
		End Get
		Set
			If (String.Equals(Me._SecondaryEmail, value) = false) Then
				Me._SecondaryEmail = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ScreenName", DbType:="NVarChar(50)")>  _
	Public Property ScreenName() As String
		Get
			Return Me._ScreenName
		End Get
		Set
			If (String.Equals(Me._ScreenName, value) = false) Then
				Me._ScreenName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkPhone", DbType:="NVarChar(50)")>  _
	Public Property WorkPhone() As String
		Get
			Return Me._WorkPhone
		End Get
		Set
			If (String.Equals(Me._WorkPhone, value) = false) Then
				Me._WorkPhone = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomePhone", DbType:="NVarChar(50)")>  _
	Public Property HomePhone() As String
		Get
			Return Me._HomePhone
		End Get
		Set
			If (String.Equals(Me._HomePhone, value) = false) Then
				Me._HomePhone = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FaxNumber", DbType:="NVarChar(50)")>  _
	Public Property FaxNumber() As String
		Get
			Return Me._FaxNumber
		End Get
		Set
			If (String.Equals(Me._FaxNumber, value) = false) Then
				Me._FaxNumber = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PagerNumber", DbType:="NVarChar(50)")>  _
	Public Property PagerNumber() As String
		Get
			Return Me._PagerNumber
		End Get
		Set
			If (String.Equals(Me._PagerNumber, value) = false) Then
				Me._PagerNumber = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MobileNumber", DbType:="NVarChar(50)")>  _
	Public Property MobileNumber() As String
		Get
			Return Me._MobileNumber
		End Get
		Set
			If (String.Equals(Me._MobileNumber, value) = false) Then
				Me._MobileNumber = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomeAddress", DbType:="NVarChar(50)")>  _
	Public Property HomeAddress() As String
		Get
			Return Me._HomeAddress
		End Get
		Set
			If (String.Equals(Me._HomeAddress, value) = false) Then
				Me._HomeAddress = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomeAddress2", DbType:="NVarChar(50)")>  _
	Public Property HomeAddress2() As String
		Get
			Return Me._HomeAddress2
		End Get
		Set
			If (String.Equals(Me._HomeAddress2, value) = false) Then
				Me._HomeAddress2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomeCity", DbType:="NVarChar(50)")>  _
	Public Property HomeCity() As String
		Get
			Return Me._HomeCity
		End Get
		Set
			If (String.Equals(Me._HomeCity, value) = false) Then
				Me._HomeCity = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomeState", DbType:="NVarChar(50)")>  _
	Public Property HomeState() As String
		Get
			Return Me._HomeState
		End Get
		Set
			If (String.Equals(Me._HomeState, value) = false) Then
				Me._HomeState = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomeZipCode", DbType:="NVarChar(50)")>  _
	Public Property HomeZipCode() As String
		Get
			Return Me._HomeZipCode
		End Get
		Set
			If (String.Equals(Me._HomeZipCode, value) = false) Then
				Me._HomeZipCode = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomeCountry", DbType:="NVarChar(50)")>  _
	Public Property HomeCountry() As String
		Get
			Return Me._HomeCountry
		End Get
		Set
			If (String.Equals(Me._HomeCountry, value) = false) Then
				Me._HomeCountry = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkAddress", DbType:="NVarChar(50)")>  _
	Public Property WorkAddress() As String
		Get
			Return Me._WorkAddress
		End Get
		Set
			If (String.Equals(Me._WorkAddress, value) = false) Then
				Me._WorkAddress = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkAddress2", DbType:="NVarChar(50)")>  _
	Public Property WorkAddress2() As String
		Get
			Return Me._WorkAddress2
		End Get
		Set
			If (String.Equals(Me._WorkAddress2, value) = false) Then
				Me._WorkAddress2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkCity", DbType:="NVarChar(50)")>  _
	Public Property WorkCity() As String
		Get
			Return Me._WorkCity
		End Get
		Set
			If (String.Equals(Me._WorkCity, value) = false) Then
				Me._WorkCity = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkState", DbType:="NVarChar(50)")>  _
	Public Property WorkState() As String
		Get
			Return Me._WorkState
		End Get
		Set
			If (String.Equals(Me._WorkState, value) = false) Then
				Me._WorkState = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkZipCode", DbType:="NVarChar(50)")>  _
	Public Property WorkZipCode() As String
		Get
			Return Me._WorkZipCode
		End Get
		Set
			If (String.Equals(Me._WorkZipCode, value) = false) Then
				Me._WorkZipCode = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkCountry", DbType:="NVarChar(50)")>  _
	Public Property WorkCountry() As String
		Get
			Return Me._WorkCountry
		End Get
		Set
			If (String.Equals(Me._WorkCountry, value) = false) Then
				Me._WorkCountry = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_JobTitle", DbType:="NVarChar(50)")>  _
	Public Property JobTitle() As String
		Get
			Return Me._JobTitle
		End Get
		Set
			If (String.Equals(Me._JobTitle, value) = false) Then
				Me._JobTitle = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Department", DbType:="NVarChar(50)")>  _
	Public Property Department() As String
		Get
			Return Me._Department
		End Get
		Set
			If (String.Equals(Me._Department, value) = false) Then
				Me._Department = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Organization", DbType:="NVarChar(50)")>  _
	Public Property Organization() As String
		Get
			Return Me._Organization
		End Get
		Set
			If (String.Equals(Me._Organization, value) = false) Then
				Me._Organization = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WebPage1", DbType:="NVarChar(50)")>  _
	Public Property WebPage1() As String
		Get
			Return Me._WebPage1
		End Get
		Set
			If (String.Equals(Me._WebPage1, value) = false) Then
				Me._WebPage1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WebPage2", DbType:="NVarChar(50)")>  _
	Public Property WebPage2() As String
		Get
			Return Me._WebPage2
		End Get
		Set
			If (String.Equals(Me._WebPage2, value) = false) Then
				Me._WebPage2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthYear", DbType:="NVarChar(50)")>  _
	Public Property BirthYear() As String
		Get
			Return Me._BirthYear
		End Get
		Set
			If (String.Equals(Me._BirthYear, value) = false) Then
				Me._BirthYear = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthMonth", DbType:="NVarChar(50)")>  _
	Public Property BirthMonth() As String
		Get
			Return Me._BirthMonth
		End Get
		Set
			If (String.Equals(Me._BirthMonth, value) = false) Then
				Me._BirthMonth = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthDay", DbType:="NVarChar(50)")>  _
	Public Property BirthDay() As String
		Get
			Return Me._BirthDay
		End Get
		Set
			If (String.Equals(Me._BirthDay, value) = false) Then
				Me._BirthDay = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Groups", DbType:="NVarChar(50)")>  _
	Public Property Groups() As String
		Get
			Return Me._Groups
		End Get
		Set
			If (String.Equals(Me._Groups, value) = false) Then
				Me._Groups = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="NVarChar(50)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me._Gender = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Picture", DbType:="NVarChar(50)")>  _
	Public Property Picture() As String
		Get
			Return Me._Picture
		End Get
		Set
			If (String.Equals(Me._Picture, value) = false) Then
				Me._Picture = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Custom4", DbType:="NVarChar(50)")>  _
	Public Property Custom4() As String
		Get
			Return Me._Custom4
		End Get
		Set
			If (String.Equals(Me._Custom4, value) = false) Then
				Me._Custom4 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Notes", DbType:="NVarChar(50)")>  _
	Public Property Notes() As String
		Get
			Return Me._Notes
		End Get
		Set
			If (String.Equals(Me._Notes, value) = false) Then
				Me._Notes = value
			End If
		End Set
	End Property
End Class
