using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0.15,0.15,0,0,0,0,0]")]
	public partial class PlayerVer1NetworkObject : NetworkObject
	{
		public const int IDENTITY = 6;

		private byte[] _dirtyFields = new byte[1];

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
		private int _charType;
		public event FieldEvent<int> charTypeChanged;
		public Interpolated<int> charTypeInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int charType
		{
			get { return _charType; }
			set
			{
				// Don't do anything if the value is the same
				if (_charType == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_charType = value;
				hasDirtyFields = true;
			}
		}

		public void SetcharTypeDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_charType(ulong timestep)
		{
			if (charTypeChanged != null) charTypeChanged(_charType, timestep);
			if (fieldAltered != null) fieldAltered("charType", _charType, timestep);
		}
		[ForgeGeneratedField]
		private bool _isGrounded;
		public event FieldEvent<bool> isGroundedChanged;
		public Interpolated<bool> isGroundedInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool isGrounded
		{
			get { return _isGrounded; }
			set
			{
				// Don't do anything if the value is the same
				if (_isGrounded == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_isGrounded = value;
				hasDirtyFields = true;
			}
		}

		public void SetisGroundedDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_isGrounded(ulong timestep)
		{
			if (isGroundedChanged != null) isGroundedChanged(_isGrounded, timestep);
			if (fieldAltered != null) fieldAltered("isGrounded", _isGrounded, timestep);
		}
		[ForgeGeneratedField]
		private int _animationType;
		public event FieldEvent<int> animationTypeChanged;
		public Interpolated<int> animationTypeInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int animationType
		{
			get { return _animationType; }
			set
			{
				// Don't do anything if the value is the same
				if (_animationType == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_animationType = value;
				hasDirtyFields = true;
			}
		}

		public void SetanimationTypeDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_animationType(ulong timestep)
		{
			if (animationTypeChanged != null) animationTypeChanged(_animationType, timestep);
			if (fieldAltered != null) fieldAltered("animationType", _animationType, timestep);
		}
		[ForgeGeneratedField]
		private int _damage;
		public event FieldEvent<int> damageChanged;
		public Interpolated<int> damageInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int damage
		{
			get { return _damage; }
			set
			{
				// Don't do anything if the value is the same
				if (_damage == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_damage = value;
				hasDirtyFields = true;
			}
		}

		public void SetdamageDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_damage(ulong timestep)
		{
			if (damageChanged != null) damageChanged(_damage, timestep);
			if (fieldAltered != null) fieldAltered("damage", _damage, timestep);
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
				_dirtyFields[0] |= 0x40;
				_lives = value;
				hasDirtyFields = true;
			}
		}

		public void SetlivesDirty()
		{
			_dirtyFields[0] |= 0x40;
			hasDirtyFields = true;
		}

		private void RunChange_lives(ulong timestep)
		{
			if (livesChanged != null) livesChanged(_lives, timestep);
			if (fieldAltered != null) fieldAltered("lives", _lives, timestep);
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
			charTypeInterpolation.current = charTypeInterpolation.target;
			isGroundedInterpolation.current = isGroundedInterpolation.target;
			animationTypeInterpolation.current = animationTypeInterpolation.target;
			damageInterpolation.current = damageInterpolation.target;
			livesInterpolation.current = livesInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _position);
			UnityObjectMapper.Instance.MapBytes(data, _rotation);
			UnityObjectMapper.Instance.MapBytes(data, _charType);
			UnityObjectMapper.Instance.MapBytes(data, _isGrounded);
			UnityObjectMapper.Instance.MapBytes(data, _animationType);
			UnityObjectMapper.Instance.MapBytes(data, _damage);
			UnityObjectMapper.Instance.MapBytes(data, _lives);

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
			_charType = UnityObjectMapper.Instance.Map<int>(payload);
			charTypeInterpolation.current = _charType;
			charTypeInterpolation.target = _charType;
			RunChange_charType(timestep);
			_isGrounded = UnityObjectMapper.Instance.Map<bool>(payload);
			isGroundedInterpolation.current = _isGrounded;
			isGroundedInterpolation.target = _isGrounded;
			RunChange_isGrounded(timestep);
			_animationType = UnityObjectMapper.Instance.Map<int>(payload);
			animationTypeInterpolation.current = _animationType;
			animationTypeInterpolation.target = _animationType;
			RunChange_animationType(timestep);
			_damage = UnityObjectMapper.Instance.Map<int>(payload);
			damageInterpolation.current = _damage;
			damageInterpolation.target = _damage;
			RunChange_damage(timestep);
			_lives = UnityObjectMapper.Instance.Map<int>(payload);
			livesInterpolation.current = _lives;
			livesInterpolation.target = _lives;
			RunChange_lives(timestep);
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
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _charType);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _isGrounded);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _animationType);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _damage);
			if ((0x40 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _lives);

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
				if (charTypeInterpolation.Enabled)
				{
					charTypeInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					charTypeInterpolation.Timestep = timestep;
				}
				else
				{
					_charType = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_charType(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (isGroundedInterpolation.Enabled)
				{
					isGroundedInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					isGroundedInterpolation.Timestep = timestep;
				}
				else
				{
					_isGrounded = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_isGrounded(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (animationTypeInterpolation.Enabled)
				{
					animationTypeInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					animationTypeInterpolation.Timestep = timestep;
				}
				else
				{
					_animationType = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_animationType(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (damageInterpolation.Enabled)
				{
					damageInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					damageInterpolation.Timestep = timestep;
				}
				else
				{
					_damage = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_damage(timestep);
				}
			}
			if ((0x40 & readDirtyFlags[0]) != 0)
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
			if (charTypeInterpolation.Enabled && !charTypeInterpolation.current.UnityNear(charTypeInterpolation.target, 0.0015f))
			{
				_charType = (int)charTypeInterpolation.Interpolate();
				//RunChange_charType(charTypeInterpolation.Timestep);
			}
			if (isGroundedInterpolation.Enabled && !isGroundedInterpolation.current.UnityNear(isGroundedInterpolation.target, 0.0015f))
			{
				_isGrounded = (bool)isGroundedInterpolation.Interpolate();
				//RunChange_isGrounded(isGroundedInterpolation.Timestep);
			}
			if (animationTypeInterpolation.Enabled && !animationTypeInterpolation.current.UnityNear(animationTypeInterpolation.target, 0.0015f))
			{
				_animationType = (int)animationTypeInterpolation.Interpolate();
				//RunChange_animationType(animationTypeInterpolation.Timestep);
			}
			if (damageInterpolation.Enabled && !damageInterpolation.current.UnityNear(damageInterpolation.target, 0.0015f))
			{
				_damage = (int)damageInterpolation.Interpolate();
				//RunChange_damage(damageInterpolation.Timestep);
			}
			if (livesInterpolation.Enabled && !livesInterpolation.current.UnityNear(livesInterpolation.target, 0.0015f))
			{
				_lives = (int)livesInterpolation.Interpolate();
				//RunChange_lives(livesInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[1];

		}

		public PlayerVer1NetworkObject() : base() { Initialize(); }
		public PlayerVer1NetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public PlayerVer1NetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
