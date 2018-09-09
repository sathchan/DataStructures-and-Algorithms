## System Design

Systems design implies a systematic approach to the design of a system. It may take a bottom-up or top-down approach, but either way the process is systematic wherein it takes into account all related components or modules of the system that needs to be created—from the architecture, to the required hardware and software, right down to the data and how it travels and transforms throughout its travel through the system. 

#### Important System Design Principles are but are not limited to-

- Decomposition - Split into Manageable and Reusable components. The design patterns are considered with finding good ways to achieve code-reuse
- Identification of right Algorithms and Data Structures
- Execution Time - System running time
- Testable 

#### Some of the Architecture tenants are - 
	
- Cloud
- Multi-tenant
- Failures (Fault Tolerance and Resiliency)
- Scalability - All components must be Horizontally scalable. Consider parallelism wherever useful
- Extensible - Add something to the existing system
- Availability (HA, DR) – Always On Architecture 
- Security
- Performance
- Asynchronous 
- Automation, Infrastructure as Code
- Continuous Integration and Deployment
- Operations, Monitoring
- Instrumentation
- Flighting - Feature Parity 

### 1. Consistent Hashing

*Scenarios where to use CONSISTENT HASHING*
- You have a cluster of databases and you need to elastically scale them up or down based on traffic load. For example, add more servers during Christmas to handle the extra traffic.
- You have a set of cache servers that need to elastically scale up or down based on traffic load. That is add or remove servers based on the traffic load

Hence Consistent hashing is one of the techniques used to bake in scalability into the storage architecture of your system from grounds up. Distributed caches that power many high-traffic websites and web applications, typically consist of a particular case of distributed hashing. These take advantage of an algorithm known as consistent hashing.

*Why we need Consistent hashing and not the conventional hashing?*

<div align="center">
  <img src="https://github.com/sathchan/SystemDesigns-and-Programming/blob/master/assets/ConventionalHashing_Model.jpg" alt="" width="600"/>
  <br>
</div>

Let's say in the above example, we have used service hashing where 
	
- Generate a hash of the key from the incoming data :  " hashValue = HashFunction(Key)"
- Figure out the server to send the data to by taking the modulo ("%") of the hashValue using the number of current db servers, n : "serverIndex = hashValue % n"

|KEY	 |HASH		|HASH mod 3 |
|:------:|:-------------|:----------|
|"john"	 |1633428562	|2	    |
|"bill"	 |7594634739	|0	    |
|"jane"	 |5000799124	|1	    |
|"steve" |9787173343	|0	    |
|"kate"	 |3421657995	|2	    |

Limitations with the above scheme is not horizontally scalable. If we add or remove servers from the set, all our existing mappings are broken. 
	
*How Consistent Hashing helps?*

We need a distribution scheme that does not depend directly on the number of servers, so that, when adding or removing servers, the number of keys that need to be relocated is minimized. One such scheme—a clever, yet surprisingly simple one—is called consistent hashing.

<div align="center">
  <img src="https://github.com/sathchan/SystemDesigns-and-Programming/blob/master/assets/ConsistentHashing_Model.jpg" alt="" width="600"/>
  <br>
</div>

**Q**: If a server crashes how do keys are redistributed from that server as the server is offline?
**A**: If we think of backup server. No it is not required. Let's say key 'A' was in the caching server 'S1' and the server S1 now crashed. With consistent hashing in place, when an external agent runs the hashing function on key 'A', it now maps to, say, caching server 'S2' since S1 is gone. We then go and query for key 'A' in S2. Since S2 does not have that key, we run into a cache miss. This results in reaching out to the database to retrieve the value for key 'A'. This key/value pair is now stored in server S2 and also returned to the external requesting client.
	
This is how the key A 'moved' from server S1 to S2, through a cache miss

### 2. CAP Theorem

The acronym CAP summarizes the terms Consistency, Availability and Partition Tolerance. In a distributed system
	
- *Consistency* means that all nodes see the same data at the same time.
- *Availability* means a guarantee that every request receives a response about whether it was successful or failed
- *Partition Tolerance* means the system continues to operate despite arbitrary message loss. 

<div align="center">
  <img src="https://github.com/sathchan/SystemDesigns-and-Programming/blob/master/assets/CAP_1.png" alt="" width="600"/>
  <br>
</div>

When you are designing a distributed system you can get cannot achieve all three of Consistency, Availability and Partition tolerance. You can pick only two of.
	

Any given distributed system is located on one of the sides (CA), (CP) or (AP) of our triangle. In real world 24/7 applications high availability is always required. So it can be questioned if a (CP) system makes any sense and if our choice is only between (CA) and (AP).


Cloud platforms rely on horizontal scaling (scale-out), i.e. the load is distributed over a lot of single nodes

<div align="center">
  <img src="https://github.com/sathchan/SystemDesigns-and-Programming/blob/master/assets/cloud_elastic.png" alt="" width="600"/>
  <br>
</div>

For that reason a cloud infrastructure has to cope with regular outages of single nodes (partition tolerance). High availability is a must have, since the end user will not tolerate response times above a certain level. Cloud platform (or at least large parts of it) is an (AP) system. Because of the CAP theorem we can’t have ACID consistency in an (AP) system

### 3. Load Balancing

Two of the most critical requirements for any online service provider are availability and redundancy. If even a single component fails or is overwhelmed by requests, the server is overloaded and both the customer and the business suffer.
	
Load balancing attempts to resolve this issue by sharing the workload across multiple components. An incoming request can be routed from an overtaxed server to one that has more resources available. Load balancing has a variety of applications from network switches to database servers

<div align="center">
  <img src="https://github.com/sathchan/SystemDesigns-and-Programming/blob/master/assets/LoadBalancing.gif" alt="" width="600"/>
  <br>
</div>

*References*: 

https://www.toptal.com/big-data/consistent-hashing

http://www.acodersjourney.com/2017/10/system-design-interview-consistent-hashing/

https://blog.codecentric.de/en/2012/02/cloud-computing-basics-cap-theorem-2/

http://ksat.me/a-plain-english-introduction-to-cap-theorem/

https://blog.stackpath.com/glossary/load-balancing/
