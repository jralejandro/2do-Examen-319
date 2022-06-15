def fibo3(n: Int): Int = {
  n match {
    case 0  => 0
    case 1 | 2 => 1
    case _ => fibo3(n - 1) + fibo3(n - 2) + fibo3(n - 3)
  }
}
def fibonacci3(n: Int): IndexedSeq[Int] = {
  for (i <- 0 until n) yield fibo3(i)
}
def fiboE3(n: Int): Int = {
    n match {
        var a = 0
        var b = 1
        var c = 1
        var total = 0
        case 1 => print("0")
        case 2 => print("0,1")
        case 3 => print("0,1,1")
        case _ => for (i <- 0 until n - 3){
                    total = a + b + c
                    a = b
                    b = c
                    c = total
                    print(total)
        }
    }
}
def fibonacciEst3(n: Int): IndexedSeq[Int] = {
  for (i <- 0 until n) yield fiboE3(i)
}
def main (args):Array[String]):Unit = {
    print("1. Fibonacci de 3 numeros")
    for (i <- fibonacci3(10)) print(i + "  ")
    print("1. Fibonacci de 3 numeros")
    print(fibonacciEst3(20))
}
