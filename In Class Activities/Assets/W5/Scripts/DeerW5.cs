using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

[RequireComponent(typeof(NavMeshAgent))]
class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_target.position);
    }
}