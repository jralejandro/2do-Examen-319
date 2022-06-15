-- 1. fibonacci de 3 elementos
fibo3 n
    | n == 0 = 0
    | n == 1 = 1
    | n == 2 = 1
    | n > 2 = fibo3(n-1) + fibo3(n-2) + fibo3(n-3)

fibonacci3 n = [ fibo3 i | i <- [ 0 .. (n - 1)] ]

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
fibonacciEst3 n = [ fiboE3 i | i <- [ 0 .. (n - 1)] ]

main = do
    putStr "\n1. Fibonacci de 3 terminos\n--------------------------------\n"
    print(fibonacci3 20)
    putStr "\n1. Fibonacci de 3 terminos\n--------------------------------\n"
    print(fibonacciEst3 20)