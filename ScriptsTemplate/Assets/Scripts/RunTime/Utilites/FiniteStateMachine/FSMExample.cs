
using System.Linq;
using UnityEngine;

namespace MyUtilities.FSM
{
    /*

    public class FSMExample : MonoBehaviour
    {
        
          *** Some variables ***
        public event Action<int> OnGatheredChanged;

        [SerializeField] private int _maxCarried = 20;

        private StateMachineBese _stateMachine;
        private int _gathered;

        public GatherableResource Target { get; set; }
        public StockPile StockPile { get; set; }



        private void Start()
        {
             *** Get some ref ***
            var navMeshAgent = GetComponent<NavMeshAgent>();
            var animator = GetComponent<Animator>();
            var enemyDetector = gameObject.AddComponent<EnemyDetector>();
            var fleeParticleSystem = gameObject.GetComponentInChildren<ParticleSystem>();

             *** Here State machine Start ***
             *** create state machine ***
            _stateMachine = new StateMachine();

             *** Create states ***
            var search = new SearchForResource(this);
            var moveToSelected = new MoveToSelectedResource(this, navMeshAgent, animator);
            var harvest = new HarvestResource(this, animator);
            var returnToStockpile = new ReturnToStockpile(this, navMeshAgent, animator);
            var placeResourcesInStockpile = new PlaceResourcesInStockpile(this);
            var flee = new Flee(this, navMeshAgent, enemyDetector, animator, fleeParticleSystem);

             *** Transitions using at metot below ***
            At(search, moveToSelected, HasTarget());
            At(moveToSelected, search, StuckForOverASecond());
            At(moveToSelected, harvest, ReachedResource());
            At(harvest, search, TargetIsDepletedAndICanCarryMore());
            At(harvest, returnToStockpile, InventoryFull());
            At(returnToStockpile, placeResourcesInStockpile, ReachedStockpile());
            At(placeResourcesInStockpile, search, () => _gathered == 0);

            _stateMachine.AddAnyTransition(flee, () => enemyDetector.EnemyInRange);
            At(flee, search, () => enemyDetector.EnemyInRange == false);
            _stateMachine.SetState(search);

              *** Some metots ***
            void At(IState to, IState from, Func<bool> condition) => _stateMachine.AddTransition(to, from, condition); // shortcut for add transition.
             *** Conditions for transition ***
            Func<bool> HasTarget() => () => Target != null;
            Func<bool> StuckForOverASecond() => () => moveToSelected.TimeStuck > 1f;
            Func<bool> ReachedResource() => () => Target != null &&
                                                  Vector3.Distance(transform.position, Target.transform.position) < 1f;

            Func<bool> TargetIsDepletedAndICanCarryMore() => () => (Target == null || Target.IsDepleted) && !InventoryFull().Invoke();
            Func<bool> InventoryFull() => () => _gathered >= _maxCarried;
            Func<bool> ReachedStockpile() => () => StockPile != null &&
                                                   Vector3.Distance(transform.position, StockPile.transform.position) < 1f;
        }
        
        *** Update ***
        private void Update() => _stateMachine.Tick();

        
    }
    */

    // *** State Example ***
    /*
    public class SearchForResource : IState
    {
        private readonly Gatherer _gatherer;

        public SearchForResource(Gatherer gatherer)
        {
            _gatherer = gatherer;
        }
        public void Tick()
        {
            _gatherer.Target = ChooseOneOfTheNearestResources(5);
        }

        private GatherableResource ChooseOneOfTheNearestResources(int pickFromNearest)
        {
            // Do some thing...
        }

        public void OnEnter() { }
        public void OnExit() { }
    }
    */
}
