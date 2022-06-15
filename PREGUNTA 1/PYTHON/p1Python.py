#-----------------SERIE ESTRUCTURADA--------------------
def fibonacci(n):
    a=0
    b=1
    c=1
    if n==1:
        print(a)
    elif n==2:
        print(a)
        print(b)
    elif n==3:
        print(a)
        print(b)
        print(c)
    else:
        print(a)
        print(b)
        print(c)
        for i in range(n-3):
            total = a + b + c
            a=b
            b=c
            c= total
            print(total)
         
fibonacci(15)
#-----------------SERIE RECURSIVA--------------------
def fibonacci(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    elif n == 2:
        return 1
    else:
        return fibonacci(n-1) + fibonacci(n-2) + fibonacci(n-3)
for i in range(5):
    print(fibonacci(i))
