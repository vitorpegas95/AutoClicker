Module Settings

    Dim startKey As Keys
    Dim stopKey As Keys

    Sub setStartKey(e As Keys)
        startKey = e
        My.Settings.startKey = e
    End Sub

    Sub setStopKey(e As Keys)
        stopKey = e
        My.Settings.stopKey = e
    End Sub

    Public Function getStartKey() As Keys
        Return startKey
    End Function

    Public Function getStopKey() As Keys
        Return stopKey
    End Function


End Module
