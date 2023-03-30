import time
"""
git avaiable
baekjoon prob
ps 1st
"""
def check_pn(a):
    A=a
    cn=3
    while(A>=cn):
        if(A==cn):
            return True
            break
        elif(A%cn==0):
            return False
            break
        else:
            cn+=2
            
def make_prime(a,n):
    pn=[1,3,7,9]
    if(n==1):
        print(a)
        exit
    for i in range(len(pn)):
        num=a*10+pn[i]
        if(a+pn[i]%3!=0 and (a-2*pn[i])%7!=0):
            if(check_pn(num)):
                make_prime(num,n-1)
start=time.time()
fn=[2,3,5,7] 
N=int(input())
for i in range(len(fn)):
    make_prime(fn[i],N)
end=time.time()
print(f"{end - start:.5f} sec")
