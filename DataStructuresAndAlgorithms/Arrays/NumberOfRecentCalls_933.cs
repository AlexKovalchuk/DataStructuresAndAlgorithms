
namespace DataStructuresAndAlgorithms.Arrays;


/*
 * You have a RecentCounter class which counts the number of recent requests within a certain time frame.
   
   Implement the RecentCounter class:
   
   RecentCounter() Initializes the counter with zero recent requests.
   int ping(int t) Adds a new request at time t, where t represents some time in milliseconds, 
   and returns the number of requests that has happened in the past 3000 milliseconds (including the new request). 
   Specifically, return the number of requests that have happened in the inclusive range [t - 3000, t].
   It is guaranteed that every call to ping uses a strictly larger value of t than the previous call.
 */

public class NumberOfRecentCalls_933
{
    private Queue<int> _queue;
    private readonly int _pingTime = 3000;
    // try queue and binary searching upper bound and compare time complexity
    public NumberOfRecentCalls_933()
    {
        _queue = new Queue<int>();
    }
    
    public int Ping(int t)
    {
        _queue.Enqueue(t);
        while (_queue.Peek() < (t - _pingTime))
        {
            _queue.Dequeue();
        }
        
        return _queue.Count;
    }
    
    /*
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
    */
    
}