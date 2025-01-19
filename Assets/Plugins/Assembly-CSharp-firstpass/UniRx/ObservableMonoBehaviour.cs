using UnityEngine;
using UnityEngine.SceneManagement;

namespace UniRx
{
	public class ObservableMonoBehaviour : TypedMonoBehaviour
	{
		private Subject<Unit> awake;

		private Subject<Unit> fixedUpdate;

		private Subject<Unit> lateUpdate;

		private Subject<int> onAnimatorIK;

		private Subject<Unit> onAnimatorMove;

		private Subject<bool> onApplicationFocus;

		private Subject<bool> onApplicationPause;

		private Subject<Unit> onApplicationQuit;

		private Subject<Tuple<float[], int>> onAudioFilterRead;

		private Subject<Unit> onBecameInvisible;

		private Subject<Unit> onBecameVisible;

		private Subject<Collision> onCollisionEnter;

		private Subject<Collision2D> onCollisionEnter2D;

		private Subject<Collision> onCollisionExit;

		private Subject<Collision2D> onCollisionExit2D;

		private Subject<Collision> onCollisionStay;

		private Subject<Collision2D> onCollisionStay2D;

		private Subject<Unit> onConnectedToServer;

		private Subject<ControllerColliderHit> onControllerColliderHit;

		private Subject<Unit> onDestroy;

		private Subject<Unit> onDisable;

		private Subject<Unit> onDrawGizmos;

		private Subject<Unit> onDrawGizmosSelected;

		private Subject<Unit> onEnable;

		private Subject<float> onJointBreak;

		private Subject<Scene> onSceneLoaded;

		private Subject<Unit> onMouseDown;

		private Subject<Unit> onMouseDrag;

		private Subject<Unit> onMouseEnter;

		private Subject<Unit> onMouseExit;

		private Subject<Unit> onMouseOver;

		private Subject<Unit> onMouseUp;

		private Subject<Unit> onMouseUpAsButton;

		private Subject<GameObject> onParticleCollision;

		private Subject<Unit> onPostRender;

		private Subject<Unit> onPreCull;

		private Subject<Unit> onPreRender;

		private Subject<Tuple<RenderTexture, RenderTexture>> onRenderImage;

		private Subject<Unit> onRenderObject;

		private Subject<Unit> onServerInitialized;

		private Subject<Collider> onTriggerEnter;

		private Subject<Collider2D> onTriggerEnter2D;

		private Subject<Collider> onTriggerExit;

		private Subject<Collider2D> onTriggerExit2D;

		private Subject<Collider> onTriggerStay;

		private Subject<Collider2D> onTriggerStay2D;

		private Subject<Unit> onValidate;

		private Subject<Unit> onWillRenderObject;

		private Subject<Unit> reset;

		private Subject<Unit> start;

		private Subject<Unit> update;

		private Subject<NetworkDisconnection> onDisconnectedFromServer;

		private Subject<NetworkConnectionError> onFailedToConnect;

		private Subject<NetworkConnectionError> onFailedToConnectToMasterServer;

		private Subject<MasterServerEvent> onMasterServerEvent;

		private Subject<NetworkMessageInfo> onNetworkInstantiate;

		private Subject<NetworkPlayer> onPlayerConnected;

		private Subject<NetworkPlayer> onPlayerDisconnected;

		private Subject<Tuple<BitStream, NetworkMessageInfo>> onSerializeNetworkView;

		public override void Awake()
		{
		}

		public IObservable<Unit> AwakeAsObservable()
		{
			return null;
		}

		public override void FixedUpdate()
		{
		}

		public IObservable<Unit> FixedUpdateAsObservable()
		{
			return null;
		}

		public override void LateUpdate()
		{
		}

		public IObservable<Unit> LateUpdateAsObservable()
		{
			return null;
		}

		public override void OnAnimatorIK(int layerIndex)
		{
		}

		public IObservable<int> OnAnimatorIKAsObservable()
		{
			return null;
		}

		public override void OnAnimatorMove()
		{
		}

		public IObservable<Unit> OnAnimatorMoveAsObservable()
		{
			return null;
		}

		public override void OnApplicationFocus(bool focus)
		{
		}

		public IObservable<bool> OnApplicationFocusAsObservable()
		{
			return null;
		}

		public override void OnApplicationPause(bool pause)
		{
		}

		public IObservable<bool> OnApplicationPauseAsObservable()
		{
			return null;
		}

		public override void OnApplicationQuit()
		{
		}

		public IObservable<Unit> OnApplicationQuitAsObservable()
		{
			return null;
		}

		public override void OnAudioFilterRead(float[] data, int channels)
		{
		}

		public IObservable<Tuple<float[], int>> OnAudioFilterReadAsObservable()
		{
			return null;
		}

		public override void OnBecameInvisible()
		{
		}

		public IObservable<Unit> OnBecameInvisibleAsObservable()
		{
			return null;
		}

		public override void OnBecameVisible()
		{
		}

		public IObservable<Unit> OnBecameVisibleAsObservable()
		{
			return null;
		}

		public override void OnCollisionEnter(Collision collision)
		{
		}

		public IObservable<Collision> OnCollisionEnterAsObservable()
		{
			return null;
		}

		public override void OnCollisionEnter2D(Collision2D coll)
		{
		}

		public IObservable<Collision2D> OnCollisionEnter2DAsObservable()
		{
			return null;
		}

		public override void OnCollisionExit(Collision collisionInfo)
		{
		}

		public IObservable<Collision> OnCollisionExitAsObservable()
		{
			return null;
		}

		public override void OnCollisionExit2D(Collision2D coll)
		{
		}

		public IObservable<Collision2D> OnCollisionExit2DAsObservable()
		{
			return null;
		}

		public override void OnCollisionStay(Collision collisionInfo)
		{
		}

		public IObservable<Collision> OnCollisionStayAsObservable()
		{
			return null;
		}

		public override void OnCollisionStay2D(Collision2D coll)
		{
		}

		public IObservable<Collision2D> OnCollisionStay2DAsObservable()
		{
			return null;
		}

		public override void OnConnectedToServer()
		{
		}

		public IObservable<Unit> OnConnectedToServerAsObservable()
		{
			return null;
		}

		public override void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		public IObservable<ControllerColliderHit> OnControllerColliderHitAsObservable()
		{
			return null;
		}

		public override void OnDestroy()
		{
		}

		public IObservable<Unit> OnDestroyAsObservable()
		{
			return null;
		}

		public override void OnDisable()
		{
		}

		public IObservable<Unit> OnDisableAsObservable()
		{
			return null;
		}

		public override void OnDrawGizmos()
		{
		}

		public IObservable<Unit> OnDrawGizmosAsObservable()
		{
			return null;
		}

		public override void OnDrawGizmosSelected()
		{
		}

		public IObservable<Unit> OnDrawGizmosSelectedAsObservable()
		{
			return null;
		}

		public override void OnEnable()
		{
		}

		public IObservable<Unit> OnEnableAsObservable()
		{
			return null;
		}

		public override void OnJointBreak(float breakForce)
		{
		}

		public IObservable<float> OnJointBreakAsObservable()
		{
			return null;
		}

		public override void OnSceneLoaded(Scene scene, LoadSceneMode mode = LoadSceneMode.Single)
		{
		}

		public IObservable<Scene> OnLevelWasLoadedAsObservable()
		{
			return null;
		}

		public override void OnMouseDown()
		{
		}

		public IObservable<Unit> OnMouseDownAsObservable()
		{
			return null;
		}

		public override void OnMouseDrag()
		{
		}

		public IObservable<Unit> OnMouseDragAsObservable()
		{
			return null;
		}

		public override void OnMouseEnter()
		{
		}

		public IObservable<Unit> OnMouseEnterAsObservable()
		{
			return null;
		}

		public override void OnMouseExit()
		{
		}

		public IObservable<Unit> OnMouseExitAsObservable()
		{
			return null;
		}

		public override void OnMouseOver()
		{
		}

		public IObservable<Unit> OnMouseOverAsObservable()
		{
			return null;
		}

		public override void OnMouseUp()
		{
		}

		public IObservable<Unit> OnMouseUpAsObservable()
		{
			return null;
		}

		public override void OnMouseUpAsButton()
		{
		}

		public IObservable<Unit> OnMouseUpAsButtonAsObservable()
		{
			return null;
		}

		public override void OnParticleCollision(GameObject other)
		{
		}

		public IObservable<GameObject> OnParticleCollisionAsObservable()
		{
			return null;
		}

		public override void OnPostRender()
		{
		}

		public IObservable<Unit> OnPostRenderAsObservable()
		{
			return null;
		}

		public override void OnPreCull()
		{
		}

		public IObservable<Unit> OnPreCullAsObservable()
		{
			return null;
		}

		public override void OnPreRender()
		{
		}

		public IObservable<Unit> OnPreRenderAsObservable()
		{
			return null;
		}

		public override void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		public IObservable<Tuple<RenderTexture, RenderTexture>> OnRenderImageAsObservable()
		{
			return null;
		}

		public override void OnRenderObject()
		{
		}

		public IObservable<Unit> OnRenderObjectAsObservable()
		{
			return null;
		}

		public override void OnServerInitialized()
		{
		}

		public IObservable<Unit> OnServerInitializedAsObservable()
		{
			return null;
		}

		public override void OnTriggerEnter(Collider other)
		{
		}

		public IObservable<Collider> OnTriggerEnterAsObservable()
		{
			return null;
		}

		public override void OnTriggerEnter2D(Collider2D other)
		{
		}

		public IObservable<Collider2D> OnTriggerEnter2DAsObservable()
		{
			return null;
		}

		public override void OnTriggerExit(Collider other)
		{
		}

		public IObservable<Collider> OnTriggerExitAsObservable()
		{
			return null;
		}

		public override void OnTriggerExit2D(Collider2D other)
		{
		}

		public IObservable<Collider2D> OnTriggerExit2DAsObservable()
		{
			return null;
		}

		public override void OnTriggerStay(Collider other)
		{
		}

		public IObservable<Collider> OnTriggerStayAsObservable()
		{
			return null;
		}

		public override void OnTriggerStay2D(Collider2D other)
		{
		}

		public IObservable<Collider2D> OnTriggerStay2DAsObservable()
		{
			return null;
		}

		public override void OnValidate()
		{
		}

		public IObservable<Unit> OnValidateAsObservable()
		{
			return null;
		}

		public override void OnWillRenderObject()
		{
		}

		public IObservable<Unit> OnWillRenderObjectAsObservable()
		{
			return null;
		}

		public override void Reset()
		{
		}

		public IObservable<Unit> ResetAsObservable()
		{
			return null;
		}

		public override void Start()
		{
		}

		public IObservable<Unit> StartAsObservable()
		{
			return null;
		}

		public override void Update()
		{
		}

		public IObservable<Unit> UpdateAsObservable()
		{
			return null;
		}

		public override void OnDisconnectedFromServer(NetworkDisconnection info)
		{
		}

		public IObservable<NetworkDisconnection> OnDisconnectedFromServerAsObservable()
		{
			return null;
		}

		public override void OnFailedToConnect(NetworkConnectionError error)
		{
		}

		public IObservable<NetworkConnectionError> OnFailedToConnectAsObservable()
		{
			return null;
		}

		public override void OnFailedToConnectToMasterServer(NetworkConnectionError info)
		{
		}

		public IObservable<NetworkConnectionError> OnFailedToConnectToMasterServerAsObservable()
		{
			return null;
		}

		public override void OnMasterServerEvent(MasterServerEvent msEvent)
		{
		}

		public IObservable<MasterServerEvent> OnMasterServerEventAsObservable()
		{
			return null;
		}

		public override void OnNetworkInstantiate(NetworkMessageInfo info)
		{
		}

		public IObservable<NetworkMessageInfo> OnNetworkInstantiateAsObservable()
		{
			return null;
		}

		public override void OnPlayerConnected(NetworkPlayer player)
		{
		}

		public IObservable<NetworkPlayer> OnPlayerConnectedAsObservable()
		{
			return null;
		}

		public override void OnPlayerDisconnected(NetworkPlayer player)
		{
		}

		public IObservable<NetworkPlayer> OnPlayerDisconnectedAsObservable()
		{
			return null;
		}

		public override void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
		{
		}

		public IObservable<Tuple<BitStream, NetworkMessageInfo>> OnSerializeNetworkViewAsObservable()
		{
			return null;
		}
	}
}
