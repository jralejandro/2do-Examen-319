-- 1. fibonacci Recursivo de 3
fibo3 n
    | n == 0 = 0
    | n == 1 = 1
    | n == 2 = 1
    | n > 2 = fibo3(n-1) + fibo3(n-2) + fibo3(n-3)

-- 1. fibonacci Estructurado de 3
fiboE3 n
    let mutable a = 0
    let mutable b = 1
    let mutable c = 1
    let mutable total = 0
    if n = 1 then print("0")
    elif n = 2 then print("0,1")
    elif n = 3 then print("0,1,1")
    else print(a)
         print(b)
         print(c)
         [ i <- [ 0 .. (n - 3)] ]
             total <- a + b + c
             a <- b
             b <- c
             c <- total
             print(total)
                                         
main = do
    putStr "\n1. Fibonacci de 3 terminos\n--------------------------------\n"
    print(fibo3 20)
    print(fiboE3 15)