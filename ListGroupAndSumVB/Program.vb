Imports System

Module Program
    Sub Main(args As String())
        GroupList()
        Console.ReadLine()
    End Sub

    Sub GroupList()
        Dim materiallist As New List(Of Material) From {
            New Material("10001", "Fiber", 1, 100),
            New Material("10001", "Fiber", 1, 100),
            New Material("10002", "Fiber", 1, 452),
            New Material("10002", "Fiber", 1, 700),
            New Material("10001", "Fiber", 1, 300)
        }

        Dim groupMaterialList As IEnumerable(Of Material) = materiallist.GroupBy(Function(t) t.ID, Function(m) m) _
                                                                                .Select(Function(m) New Material With {
                                                                                        .ID = m.Key,
                                                                                        .category = m.First().category,
                                                                                        .count = m.Count(),
                                                                                        .meters = m.Sum(Function(p) p.meters)
                                                                                    }).ToList()

        For Each listIem As Material In groupMaterialList
            Console.WriteLine("{0} | {1} | {2} | {3}", listIem.ID, listIem.category, listIem.count, listIem.meters.ToString("#,##"))
        Next

    End Sub
End Module
