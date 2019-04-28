using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0.15,0.15,0,0,0,0,0,0,0]")]
	public partial class CharacterDriverNetworkObject : NetworkObject
	{
		public const int IDENTITY = 8;

		private byte[] _dirtyFields = new byte[2];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		[ForgeGeneratedField]
		private Vector3 _position;
		public event FieldEvent<Vector3> positionChanged;
		public InterpolateVector3 positionInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 position
		{
			get { return _position; }
			set
			{
				// Don't do anything if the value is the same
				if (_position == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_position = value;
				hasDirtyFields = true;
			}
		}

		public void SetpositionDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_position(ulong timestep)
		{
			if (positionChanged != null) positionChanged(_position, timestep);
			if (fieldAltered != null) fieldAltered("position", _position, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _rotation;
		public event FieldEvent<Quaternion> rotationChanged;
		public InterpolateQuaternion rotationInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion rotation
		{
			get { return _rotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_rotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_rotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetrotationDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_rotation(ulong timestep)
		{
			if (rotationChanged != null) rotationChanged(_rotation, timestep);
			if (fieldAltered != null) fieldAltered("rotation", _rotation, timestep);
		}
		[ForgeGeneratedField]
		private int _lives;
		public event FieldEvent<int> livesChanged;
		public Interpolated<int> livesInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int lives
		{
			get { return _lives; }
			set
			{
				// Don't do anything if the value is the same
				if (_lives == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_lives = value;
				hasDirtyFields = true;
			}
		}

		public void SetlivesDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_lives(ulong timestep)
		{
			if (livesChanged != null) livesChanged(_lives, timestep);
			if (fieldAltered != null) fieldAltered("lives", _lives, timestep);
		}
		[ForgeGeneratedField]
		private int _health;
		public event FieldEvent<int> healthChanged;
		public Interpolated<int> healthInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int health
		{
			get { return _health; }
			set
			{
				// Don't do anything if the value is the same
				if (_health == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_health = value;
				hasDirtyFields = true;
			}
		}

		public void SethealthDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_health(ulong timestep)
		{
			if (healthChanged != null) healthChanged(_health, timestep);
			if (fieldAltered != null) fieldAltered("health", _health, timestep);
		}
		[ForgeGeneratedField]
		private int _characterID;
		public event FieldEvent<int> characterIDChanged;
		public Interpolated<int> characterIDInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int characterID
		{
			get { return _characterID; }
			set
			{
				// Don't do anything if the value is the same
				if (_characterID == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_characterID = value;
				hasDirtyFields = true;
			}
		}

		public void SetcharacterIDDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_characterID(ulong timestep)
		{
			if (characterIDChanged != null) characterIDChanged(_characterID, timestep);
			if (fieldAltered != null) fieldAltered("characterID", _characterID, timestep);
		}
		[ForgeGeneratedField]
		private bool _isRunning;
		public event FieldEvent<bool> isRunningChanged;
		public Interpolated<bool> isRunningInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool isRunning
		{
			get { return _isRunning; }
			set
			{
				// Don't do anything if the value is the same
				if (_isRunning == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_isRunning = value;
				hasDirtyFields = true;
			}
		}

		public void SetisRunningDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_isRunning(ulong timestep)
		{
			if (isRunningChanged != null) isRunningChanged(_isRunning, timestep);
			if (fieldAltered != null) fieldAltered("isRunning", _isRunning, timestep);
		}
		[ForgeGeneratedField]
		private bool _isIdle;
		public event FieldEvent<bool> isIdleChanged;
		public Interpolated<bool> isIdleInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool isIdle
		{
			get { return _isIdle; }
			set
			{
				// Don't do anything if the value is the same
				if (_isIdle == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x40;
				_isIdle = value;
				hasDirtyFields = true;
			}
		}

		public void SetisIdleDirty()
		{
			_dirtyFields[0] |= 0x40;
			hasDirtyFields = true;
		}

		private void RunChange_isIdle(ulong timestep)
		{
			if (isIdleChanged != null) isIdleChanged(_isIdle, timestep);
			if (fieldAltered != null) fieldAltered("isIdle", _isIdle, timestep);
		}
		[ForgeGeneratedField]
		private bool _isAttacking;
		public event FieldEvent<bool> isAttackingChanged;
		public Interpolated<bool> isAttackingInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool isAttacking
		{
			get { return _isAttacking; }
			set
			{
				// Don't do anything if the value is the same
				if (_isAttacking == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x80;
				_isAttacking = value;
				hasDirtyFields = true;
			}
		}

		public void SetisAttackingDirty()
		{
			_dirtyFields[0] |= 0x80;
			hasDirtyFields = true;
		}

		private void RunChange_isAttacking(ulong timestep)
		{
			if (isAttackingChanged != null) isAttackingChanged(_isAttacking, timestep);
			if (fieldAltered != null) fieldAltered("isAttacking", _isAttacking, timestep);
		}
		[ForgeGeneratedField]
		private bool _isHit;
		public event FieldEvent<bool> isHitChanged;
		public Interpolated<bool> isHitInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool isHit
		{
			get { return _isHit; }
			set
			{
				// Don't do anything if the value is the same
				if (_isHit == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[1] |= 0x1;
				_isHit = value;
				hasDirtyFields = true;
			}
		}

		public void SetisHitDirty()
		{
			_dirtyFields[1] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_isHit(ulong timestep)
		{
			if (isHitChanged != null) isHitChanged(_isHit, timestep);
			if (fieldAltered != null) fieldAltered("isHit", _isHit, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			positionInterpolation.current = positionInterpolation.target;
			rotationInterpolation.current = rotationInterpolation.target;
			livesInterpolation.current = livesInterpolation.target;
			healthInterpolation.current = healthInterpolation.target;
			characterIDInterpolation.current = characterIDInterpolation.target;
			isRunningInterpolation.current = isRunningInterpolation.target;
			isIdleInterpolation.current = isIdleInterpolation.target;
			isAttackingInterpolation.current = isAttackingInterpolation.target;
			isHitInterpolation.current = isHitInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _position);
			UnityObjectMapper.Instance.MapBytes(data, _rotation);
			UnityObjectMapper.Instance.MapBytes(data, _lives);
			UnityObjectMapper.Instance.MapBytes(data, _health);
			UnityObjectMapper.Instance.MapBytes(data, _characterID);
			UnityObjectMapper.Instance.MapBytes(data, _isRunning);
			UnityObjectMapper.Instance.MapBytes(data, _isIdle);
			UnityObjectMapper.Instance.MapBytes(data, _isAttacking);
			UnityObjectMapper.Instance.MapBytes(data, _isHit);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_position = UnityObjectMapper.Instance.Map<Vector3>(payload);
			positionInterpolation.current = _position;
			positionInterpolation.target = _position;
			RunChange_position(timestep);
			_rotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			rotationInterpolation.current = _rotation;
			rotationInterpolation.target = _rotation;
			RunChange_rotation(timestep);
			_lives = UnityObjectMapper.Instance.Map<int>(payload);
			livesInterpolation.current = _lives;
			livesInterpolation.target = _lives;
			RunChange_lives(timestep);
			_health = UnityObjectMapper.Instance.Map<int>(payload);
			healthInterpolation.current = _health;
			healthInterpolation.target = _health;
			RunChange_health(timestep);
			_characterID = UnityObjectMapper.Instance.Map<int>(payload);
			characterIDInterpolation.current = _characterID;
			characterIDInterpolation.target = _characterID;
			RunChange_characterID(timestep);
			_isRunning = UnityObjectMapper.Instance.Map<bool>(payload);
			isRunningInterpolation.current = _isRunning;
			isRunningInterpolation.target = _isRunning;
			RunChange_isRunning(timestep);
			_isIdle = UnityObjectMapper.Instance.Map<bool>(payload);
			isIdleInterpolation.current = _isIdle;
			isIdleInterpolation.target = _isIdle;
			RunChange_isIdle(timestep);
			_isAttacking = UnityObjectMapper.Instance.Map<bool>(payload);
			isAttackingInterpolation.current = _isAttacking;
			isAttackingInterpolation.target = _isAttacking;
			RunChange_isAttacking(timestep);
			_isHit = UnityObjectMapper.Instance.Map<bool>(payload);
			isHitInterpolation.current = _isHit;
			isHitInterpolation.target = _isHit;
			RunChange_isHit(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _position);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rotation);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _lives);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _health);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _characterID);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _isRunning);
			if ((0x40 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _isIdle);
			if ((0x80 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _isAttacking);
			if ((0x1 & _dirtyFields[1]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _isHit);

			// Reset all the dirty fields
			for (int i = 0; i < _dirtyFields.Length; i++)
				_dirtyFields[i] = 0;

			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

			if ((0x1 & readDirtyFlags[0]) != 0)
			{
				if (positionInterpolation.Enabled)
				{
					positionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					positionInterpolation.Timestep = timestep;
				}
				else
				{
					_position = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_position(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (rotationInterpolation.Enabled)
				{
					rotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					rotationInterpolation.Timestep = timestep;
				}
				else
				{
					_rotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_rotation(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (livesInterpolation.Enabled)
				{
					livesInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					livesInterpolation.Timestep = timestep;
				}
				else
				{
					_lives = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_lives(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (healthInterpolation.Enabled)
				{
					healthInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					healthInterpolation.Timestep = timestep;
				}
				else
				{
					_health = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_health(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (characterIDInterpolation.Enabled)
				{
					characterIDInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					characterIDInterpolation.Timestep = timestep;
				}
				else
				{
					_characterID = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_characterID(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (isRunningInterpolation.Enabled)
				{
					isRunningInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					isRunningInterpolation.Timestep = timestep;
				}
				else
				{
					_isRunning = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_isRunning(timestep);
				}
			}
			if ((0x40 & readDirtyFlags[0]) != 0)
			{
				if (isIdleInterpolation.Enabled)
				{
					isIdleInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					isIdleInterpolation.Timestep = timestep;
				}
				else
				{
					_isIdle = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_isIdle(timestep);
				}
			}
			if ((0x80 & readDirtyFlags[0]) != 0)
			{
				if (isAttackingInterpolation.Enabled)
				{
					isAttackingInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					isAttackingInterpolation.Timestep = timestep;
				}
				else
				{
					_isAttacking = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_isAttacking(timestep);
				}
			}
			if ((0x1 & readDirtyFlags[1]) != 0)
			{
				if (isHitInterpolation.Enabled)
				{
					isHitInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					isHitInterpolation.Timestep = timestep;
				}
				else
				{
					_isHit = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_isHit(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (positionInterpolation.Enabled && !positionInterpolation.current.UnityNear(positionInterpolation.target, 0.0015f))
			{
				_position = (Vector3)positionInterpolation.Interpolate();
				//RunChange_position(positionInterpolation.Timestep);
			}
			if (rotationInterpolation.Enabled && !rotationInterpolation.current.UnityNear(rotationInterpolation.target, 0.0015f))
			{
				_rotation = (Quaternion)rotationInterpolation.Interpolate();
				//RunChange_rotation(rotationInterpolation.Timestep);
			}
			if (livesInterpolation.Enabled && !livesInterpolation.current.UnityNear(livesInterpolation.target, 0.0015f))
			{
				_lives = (int)livesInterpolation.Interpolate();
				//RunChange_lives(livesInterpolation.Timestep);
			}
			if (healthInterpolation.Enabled && !healthInterpolation.current.UnityNear(healthInterpolation.target, 0.0015f))
			{
				_health = (int)healthInterpolation.Interpolate();
				//RunChange_health(healthInterpolation.Timestep);
			}
			if (characterIDInterpolation.Enabled && !characterIDInterpolation.current.UnityNear(characterIDInterpolation.target, 0.0015f))
			{
				_characterID = (int)characterIDInterpolation.Interpolate();
				//RunChange_characterID(characterIDInterpolation.Timestep);
			}
			if (isRunningInterpolation.Enabled && !isRunningInterpolation.current.UnityNear(isRunningInterpolation.target, 0.0015f))
			{
				_isRunning = (bool)isRunningInterpolation.Interpolate();
				//RunChange_isRunning(isRunningInterpolation.Timestep);
			}
			if (isIdleInterpolation.Enabled && !isIdleInterpolation.current.UnityNear(isIdleInterpolation.target, 0.0015f))
			{
				_isIdle = (bool)isIdleInterpolation.Interpolate();
				//RunChange_isIdle(isIdleInterpolation.Timestep);
			}
			if (isAttackingInterpolation.Enabled && !isAttackingInterpolation.current.UnityNear(isAttackingInterpolation.target, 0.0015f))
			{
				_isAttacking = (bool)isAttackingInterpolation.Interpolate();
				//RunChange_isAttacking(isAttackingInterpolation.Timestep);
			}
			if (isHitInterpolation.Enabled && !isHitInterpolation.current.UnityNear(isHitInterpolation.target, 0.0015f))
			{
				_isHit = (bool)isHitInterpolation.Interpolate();
				//RunChange_isHit(isHitInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[2];

		}

		public CharacterDriverNetworkObject() : base() { Initialize(); }
		public CharacterDriverNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public CharacterDriverNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
