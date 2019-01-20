#ZEMMOURI Mohamed m.zemmouri@gmail.com
import multiprocessing
import sys
import ctypes

def read_Array(n = None, m = None):
    myArray=[]
    if n is None:
        n=int(input("\tEnter the matrix Row's Number : "))         
    
    if m is None:
        m=int(input("\tEnter the matrix Column's Number : "))         
  
    for i in range(n):
        row = []
        for j in range(m): 
            row.append(0)
        myArray.append(row)
    print_Array(myArray)    
    
    for i in range(n):                             
        for j in range(m): 
            print(" " * 40, end = "\r" )
            print("\tEnter the elements : ", end = "" )
            myArray[i][j] = int(input())
            sys.stdout.write("\033[" + str(n+1) + "A") 
            print_Array(myArray)    
    print(" " * 40, end = "\n" )
    return myArray

def print_Array(myArray, prefix = None): 
    n = len(myArray)
    m = len(myArray[0])
    maxlen =len(str(max(map(max, myArray))))
    if prefix is None:
        prefix = "\t"

    for i in range(n): 
        print(prefix + "|", end=" ")
        for j in range(m): 
            print(repr(myArray[i][j]).rjust(maxlen), end="  ")
        print(" |")
    
    return 

def pivot_Array(array, n, m):
    result=[]
    for i in range(n): 
        row=[]                                      
        for j in range(m): 
            row.append(array[i * m + j])              
        result.append(row)    
    return result

def sum_2DArray():

    print("\nThe Sum Of 2 Matrix")
    n=int(input("\tEnter the matrix Row's Number : "))         
    m=int(input("\tEnter the matrix Column's Number : "))         
    print("\n\tThe First Matrix")
    A=read_Array(n, m)
    print("\tThe Second Matrix")
    B=read_Array(n, m)

    managerArray = manager.Array('l', range( n * m))
    jobs = []
    for i in range(n):  
        for j in range(m):   
            p = multiprocessing.Process(target = sum_val, args=(A[i][j], B[i][j], managerArray, i * m + j))
            jobs.append(p)
            p.start()
    for p in jobs:
        p.join()      
    result = pivot_Array(managerArray, n, m)   

    print("\tThe Resultant of the Sum")
    print_Array(result)

    return result

def sum_val(valA, valB, Output, i):    
    val = valA + valB
    if Output is not None:     # shared array / multiprocessing Mode   
        Output[i] = val
    return val

def product_2DArray():
    print("\nThe Product Of 2 Matrix")
    
    n=int(input("\tEnter the First matrix Row's Number : "))         
    m=int(input("\tEnter the First matrix Column's Number : "))        
    l=int(input("\tEnter the Second matrix Row's Number : "))         

    print("\n\tThe First Matrix")
    A=read_Array(n, m)
    print("\tThe Second Matrix")
    B=read_Array(m, l)

    managerArray = manager.Array('l', range( n * m))
    jobs = []
    for i in range(n):
        rowA = A[i]
        for j in range(m):   
            colB = []
            for k in range(l):
                colB.append(B[k][j])
            p = multiprocessing.Process(target = product_Array, args=(rowA, colB, managerArray, i * m + j))
            jobs.append(p)
            p.start()
    for p in jobs:
        p.join()      
    result = pivot_Array(managerArray, n, m)

    print("\tThe Resultant of the Product")
    print_Array(result)
    return result

def product_Array(rowA, colB, Output, i):
    val = 0
    for k in range(len(rowA)):   
        val += rowA[k] * colB[k] 
    if Output is not None:     # shared array / multiprocessing Mode   
        Output[i] = val
    return val

if __name__ == '__main__':

    kernel32 = ctypes.windll.kernel32
    kernel32.SetConsoleMode(kernel32.GetStdHandle(-11), 7)      
    manager = multiprocessing.Manager() 
    while True:
        o = int(input("\nEnter Code operation [1: sum, 2: product, 0:exit] : "))          
        if o==0 :
            break
        else :
            if o==1 :
                sum_2DArray()
            else :
                if o == 2 :
                    product_2DArray()