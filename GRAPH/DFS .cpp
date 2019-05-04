#include <iostream>
#include <algorithm>
#include<vector>
#define long long ll
int node;
using namespace std;
vector<int>v1[100];
vector<int>v2;
int color[100];

void dfs_visit(int i)
{

   //cout<<i<<endl;

color[i]=2;

//cout<<x<<" "<<v1[x].size()<<endl;
for(int j =0;j<v1[i].size();j++)
{
    int x=v1[i][j];
    if(color[x]==0)
    {
        //cout<<x<<" "<<v1[i][j]<<"   ";
        dfs_visit(x);
    }
}
v2.push_back(i);
color[i]=1;


// v2.push_back(x);

}
void dfs()
{
    for(int i=0;i<node;i++)
    {
        if(color[i]==0)
        {
            dfs_visit(i);
        }
    }
}



int main()
{


cout<<"enter edge then nodes"<<endl;
    int m;
    cin>>m>>node;
    //n =nodes
    //m of edges
    for(int i=0;i<m;i++)
    {
        int p,q;
        cin>>p>>q;
        v1[p].push_back(q);
    }
   /* for(int j=0;j<m;j++)
    {
        cout<<j<<" :";
        for(int k=0;k<v1[j].size();k++)
        {
            cout<<v1[j][k]<<" ";
        }
        cout<<"\n";

    }*/
    dfs();
    for(int i=0;i<v2.size();i++)
    {
        cout<<v2[i]<<" ";
        //cout<< i <<""
    }


    return 0;
}
