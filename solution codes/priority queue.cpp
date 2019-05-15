#include <iostream> 
#include <queue> 
  
using namespace std; 
  
void showpq(priority_queue <int> pq) 
{ 
    priority_queue <int> pq2 = pq; 
    while (!g.empty()) 
    { 
        cout << '\t' << pq2.top(); 
        pq2.pop(); 
    } 
    cout << '\n'; 
} 
  
int main () 
{ 
    priority_queue <int> gquiz; 
    gquiz.push(10); 
    gquiz.push(30); 
    gquiz.push(20); 
    gquiz.push(5); 
    gquiz.push(1); 
  
    cout << "The priority queue gquiz is : "; 
    showpq(gquiz); 
  
    cout << "\ngquiz.size() : " << gquiz.size(); 
    cout << "\ngquiz.top() : " << gquiz.top(); 
  
  
    cout << "\ngquiz.pop() : "; 
    gquiz.pop(); 
    showpq(gquiz); 
  
    return 0; 
} 