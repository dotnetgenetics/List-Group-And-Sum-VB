Public Class Material
    Public Sub New()
        'default constructor
    End Sub

    Public Sub New(id As String, category As String, count As Integer, meters As Double)
        Me.ID = id
        Me.category = category
        Me.count = count
        Me.meters = meters
    End Sub

    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
    Public Property category() As String
        Get
            Return m_category
        End Get
        Set(value As String)
            m_category = value
        End Set
    End Property
    Private m_category As String
    Public Property count() As Integer
        Get
            Return m_count
        End Get
        Set(value As Integer)
            m_count = value
        End Set
    End Property
    Private m_count As Integer
    Public Property meters() As Double
        Get
            Return m_meters
        End Get
        Set(value As Double)
            m_meters = value
        End Set
    End Property
    Private m_meters As Double
End Class
