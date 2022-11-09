Module Module1
    Public numnodes = 133
    Public startlocation As locationsRec
    Public templocation As locationsRec
    Public endlocation As locationsRec
    Public locationsArray(numnodes) As locationsRec
    Public completepath(numnodes) As locationsRec
    Public accessrequirements(5) As String
    Public selAccessRequirements(5) As Boolean
    Public reqCount, locCount As Integer
    Public allDistances(numnodes, numnodes) As String
    Public allDirections(numnodes, numnodes) As String
    Public directions(numnodes) As String
    Public distances(numnodes) As String
    Public disCount = 0
    Public accPathCount As Integer
    Public numAccess = 5
    Public infinity = 999999
    Public numofNodes As Integer
    Public accArray(numnodes) As locationsRec
    Public directionsNodes(numnodes) As locationsRec
    Public validPath As Boolean
    Public heu(numnodes) As Integer
    Public Structure locationsRec
        Dim node As String
        Dim locationname As String
        Dim heuristic As Integer
        Dim ypixel As Integer
        Dim xpixel As Integer
        Dim grassYN As Boolean
        Dim cobblesYN As Boolean
        Dim narrowPathYN As Boolean
        Dim gravelYN As Boolean
        Dim curbDropYN As Boolean
    End Structure
    Function aStar(graph As Dictionary(Of String, Dictionary(Of String, Decimal)), heuristic As Dictionary(Of String, Decimal), start As String, finish As String)
        Dim distance As New Dictionary(Of String, Decimal)
        Dim plusheuristic As New Dictionary(Of String, Decimal)
        Dim prev As New Dictionary(Of String, String)
        Dim shortestpath As New List(Of String)
        Dim shortest As String
        Dim cost As Decimal
        Dim current_vertex As String
        Dim tempHeuristic As Decimal

        'Set all vertexes attributes (distances and heuristics) to infinity
        For Each vertex In graph
            distance.Add(vertex.Key, infinity)
            plusheuristic.Add(vertex.Key, infinity)
        Next
        'Set all vertexes attributes (distance and heuristic) to 0, so that the start node is the first node that is looked at.
        distance(start) = 0
        plusheuristic(start) = 0

        'Stops searching for a shortest graph when the end node has the shortest cost
        While graph.ContainsKey(finish)
            'sets the shortest node to nothing
            shortest = Nothing

            'checks each node, and finds the node with the current smallest cost.
            For Each vertex In graph
                'sets the node with the smallest cost as "shortest"
                If shortest = Nothing Then
                    shortest = vertex.Key
                ElseIf plusheuristic(vertex.Key) < plusheuristic(shortest) Then
                    shortest = vertex.Key
                End If
            Next

            'checks all nodes connected to the node iwth the shortest/smallest cost
            For Each neighbour In graph(shortest)
                'cost equals the neighbouring node being searched distance to the shortest node
                cost = neighbour.Value

                'gives the heuristic of the neighbouring node a weighted value
                If distance(shortest) <> "0" Then
                    tempHeuristic = (heuristic(neighbour.Key) / 10) * distance(shortest)
                Else
                    tempHeuristic = heuristic(neighbour.Key)
                End If
                'if the cost of the neighbouring node is smaller than the cost of previously calculated nodes
                If graph.ContainsKey(neighbour.Key) And ((cost + distance(shortest) + tempHeuristic) < plusheuristic(neighbour.Key)) Then
                    'set the new distances, heuristics and previous node
                    distance(neighbour.Key) = cost + distance(shortest)
                    plusheuristic(neighbour.Key) = cost + distance(shortest) + tempHeuristic
                    prev(neighbour.Key) = shortest
                End If

            Next
            'remove the "shortest" node as all of it's neighbouring nodes have been searched
            graph.Remove(shortest)
        End While

        current_vertex = finish
        validPath = True
        Try
            'write the shortest path into a list, in the correct order
            While current_vertex <> start
                shortestpath.Insert(0, current_vertex)
                current_vertex = prev(current_vertex)
            End While
            shortestpath.Insert(0, start)

        Catch
            'if there is no path, then there isn't a valid path
            validPath = False
        End Try
        'return the route back to the original procedure
        Return shortestpath

    End Function

    Public Sub loadDirections()

        FileOpen(5, "directions.txt", OpenMode.Output)
        For i = 0 To locCount - 1
            For j = 0 To locCount - 1
                Write(5, allDirections(i, j))
            Next
            WriteLine(5)
        Next
        FileClose(5)

    End Sub

    Public Sub readAccessRequirements()
        reqCount = 0
        FileOpen(1, "Access Requirements.txt", OpenMode.Input)
        Do While Not EOF(1)
            accessrequirements(reqCount) = LineInput(1)
            reqCount = reqCount + 1
        Loop
        FileClose(1)
    End Sub
    Public Sub readLocations()
        locCount = 0
        FileOpen(2, "Locations.txt", OpenMode.Input)
        Do While Not EOF(2)
            With locationsArray(locCount)
                Input(2, .node)
                Input(2, .locationname)
                Input(2, .heuristic)
                Input(2, .xpixel)
                Input(2, .ypixel)
                Input(2, .grassYN)
                Input(2, .cobblesYN)
                Input(2, .narrowPathYN)
                Input(2, .gravelYN)
                Input(2, .curbDropYN)
                heu(locCount) = .heuristic
                locCount = locCount + 1
            End With
        Loop

        FileClose(2)
    End Sub
    Public Sub loadDistances()

        FileOpen(3, "all distances.txt", OpenMode.Input)
        For a = 0 To locCount - 1
            For b = 0 To locCount - 1
                Input(3, allDistances(a, b))
                If CStr(allDistances(a, b)) = "" Then
                    allDistances(a, b) = infinity

                End If
                allDistances(a, b) = CDec(allDistances(a, b))
            Next
        Next
        FileClose(3)
    End Sub
    Public Sub applyAccess()

        For a = 0 To locCount - 1
            With locationsArray(a)

                If .grassYN = True And selAccessRequirements(0) = True Then
                    .heuristic = infinity
                ElseIf .cobblesYN = True And selAccessRequirements(1) = True Then
                    .heuristic = infinity
                ElseIf .narrowPathYN = True And selAccessRequirements(2) = True Then
                    .heuristic = infinity
                ElseIf .gravelYN = True And selAccessRequirements(3) = True Then
                    .heuristic = infinity
                ElseIf .curbDropYN = False And selAccessRequirements(4) = True Then
                    .heuristic = infinity
                ElseIf locationsArray(a).heuristic = 10 Then
                    .heuristic = infinity
                Else
                    .heuristic = heu(a)
                End If
            End With
        Next

    End Sub
    Public Sub readDirections()

        FileOpen(4, "All possible directions.txt", OpenMode.Input)
        For a = 0 To locCount - 1
            For b = 0 To locCount - 1
                Input(4, allDirections(a, b))
            Next
        Next
        FileClose(4)
    End Sub
End Module
