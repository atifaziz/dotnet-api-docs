﻿module add1
// <Snippet1>
open System.Numerics

let values = [ Complex(12.3, -1.4); Complex(-6.2, 3.1); Complex(8.9, 1.5) ]

for c1 in values do
    for c2 in values do
        printfn $"{c1} + {c2} = {Complex.Add(c1, c2)}"
// The example displays the following output:
//       (12.3, -1.4) + (12.3, -1.4) = (24.6, -2.8)
//       (12.3, -1.4) + (-6.2, 3.1) = (6.1, 1.7)
//       (12.3, -1.4) + (8.9, 1.5) = (21.2, 0.1)
//       (-6.2, 3.1) + (12.3, -1.4) = (6.1, 1.7)
//       (-6.2, 3.1) + (-6.2, 3.1) = (-12.4, 6.2)
//       (-6.2, 3.1) + (8.9, 1.5) = (2.7, 4.6)
//       (8.9, 1.5) + (12.3, -1.4) = (21.2, 0.1)
//       (8.9, 1.5) + (-6.2, 3.1) = (2.7, 4.6)
//       (8.9, 1.5) + (8.9, 1.5) = (17.8, 3)
// </Snippet1>
