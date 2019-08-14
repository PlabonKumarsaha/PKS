#include<bits/stdc++.h>
using namespace std;

int main()
{
    /*
    1 2 3 4
    2 3 4 1
    3 4 1 2
    4 1 2 3
    */
    int k;
for(int i = 1;i<5;i++)
{
    for(int j = 1;j<5;j++)
    {
        k = i+j-1;
        if(k>4)
        {
            k = k-4;
        }

        cout<<k<<" ";
    }
    cout<<endl;

}
}
