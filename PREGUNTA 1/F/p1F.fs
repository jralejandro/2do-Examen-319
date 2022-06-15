open System  
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    //RECURSIVO
    let rec fibo3 n = 
        if n = 0 then 0
        elif n = 1 then 1
        elif n = 2 then 1
        else fibo3 (n - 1) + fibo3 (n - 2) + fibo3 (n - 3)
    for i in 0..(5) do
        Console.WriteLine(fibo3 i)
    //ESTRUCTURADO
    let rec fiboE3 n =
        let mutable a = 0
        let mutable b = 1
        let mutable c = 1
        let mutable total = 0
        if n = 1 then Console.WriteLine("0")
        elif n = 2 then Console.WriteLine("0,1")
        elif n = 3 then Console.WriteLine("0,1,1")
        else Console.WriteLine(a)
             Console.WriteLine(b)
             Console.WriteLine(c)
             for i in 0..(n - 3) do
                total <- a + b + c
                a <- b
                b <- c
                c <- total
                Console.WriteLine(total)
                                              
    Console.WriteLine(fiboE3 15)
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
