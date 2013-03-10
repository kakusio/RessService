// Type: System.Data.Objects.ObjectContext
// Assembly: System.Data.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.Entity.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime;

namespace System.Data.Objects
{
	/// <summary>
	/// Provides facilities for querying and working with entity data as objects.
	/// </summary>
	public class ObjectContext : IDisposable
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Data.Objects.ObjectContext"/> class with the given connection. During construction, the metadata workspace is extracted from the <see cref="T:System.Data.EntityClient.EntityConnection"/> object.
		/// </summary>
		/// <param name="connection">An <see cref="T:System.Data.EntityClient.EntityConnection"/> that contains references to the model and to the data source connection.</param><exception cref="T:System.ArgumentNullException">The <paramref name="connection"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="connection"/> is invalid.-or-The metadata workspace is invalid. </exception>
		public ObjectContext(EntityConnection connection);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Data.Objects.ObjectContext"/> class with the given connection string and default entity container name.
		/// </summary>
		/// <param name="connectionString">The connection string, which also provides access to the metadata information.</param><exception cref="T:System.ArgumentNullException">The <paramref name="connectionString"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="connectionString"/> is invalid.-or-The metadata workspace is not valid. </exception>
		public ObjectContext(string connectionString);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Data.Objects.ObjectContext"/> class with a given connection string and entity container name.
		/// </summary>
		/// <param name="connectionString">The connection string, which also provides access to the metadata information.</param><param name="defaultContainerName">The name of the default entity container. When the <paramref name="defaultContainerName"/> is set through this method, the property becomes read-only.</param><exception cref="T:System.ArgumentNullException">The <paramref name="connectionString"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="connectionString"/>, <paramref name="defaultContainerName"/>, or metadata workspace is not valid.</exception>
		protected ObjectContext(string connectionString, string defaultContainerName);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Data.Objects.ObjectContext"/> class with a given connection and entity container name.
		/// </summary>
		/// <param name="connection">An <see cref="T:System.Data.EntityClient.EntityConnection"/> that contains references to the model and to the data source connection.</param><param name="defaultContainerName">The name of the default entity container. When the <paramref name="defaultContainerName"/> is set through this method, the property becomes read-only.</param><exception cref="T:System.ArgumentNullException">The <paramref name="connection"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="connection"/>, <paramref name="defaultContainerName"/>, or metadata workspace is not valid.</exception>
		protected ObjectContext(EntityConnection connection, string defaultContainerName);

		/// <summary>
		/// Accepts all changes made to objects in the object context.
		/// </summary>
		public void AcceptAllChanges();

		/// <summary>
		/// Adds an object to the object context.
		/// </summary>
		/// <param name="entitySetName">Represents the entity set name, which may optionally be qualified by the entity container name. </param><param name="entity">The <see cref="T:System.Object"/> to add.</param><exception cref="T:System.ArgumentNullException">The <paramref name="entity"/> parameter is null. -or-The <paramref name="entitySetName"/> does not qualify.</exception>
		public void AddObject(string entitySetName, object entity);

		/// <summary>
		/// Explicitly loads an object related to the supplied object by the specified navigation property and using the default merge option.
		/// </summary>
		/// <param name="entity">The entity for which related objects are to be loaded.</param><param name="navigationProperty">The name of the navigation property that returns the related objects to be loaded.</param><exception cref="T:System.InvalidOperationException">The <paramref name="entity"/> is in a <see cref="F:System.Data.EntityState.Detached"/>, <see cref="F:System.Data.EntityState.Added,"/> or <see cref="F:System.Data.EntityState.Deleted"/> state,-or-The <paramref name="entity"/> is attached to another instance of <see cref="T:System.Data.Objects.ObjectContext"/>. </exception>
		public void LoadProperty(object entity, string navigationProperty);

		/// <summary>
		/// Explicitly loads an object that is related to the supplied object by the specified navigation property and using the specified merge option.
		/// </summary>
		/// <param name="entity">The entity for which related objects are to be loaded.</param><param name="navigationProperty">The name of the navigation property that returns the related objects to be loaded.</param><param name="mergeOption">The <see cref="T:System.Data.Objects.MergeOption"/> value to use when you load the related objects.</param><exception cref="T:System.InvalidOperationException">The <paramref name="entity"/> is in a <see cref="F:System.Data.EntityState.Detached"/>, <see cref="F:System.Data.EntityState.Added,"/> or <see cref="F:System.Data.EntityState.Deleted"/> state,-or-The <paramref name="entity"/> is attached to another instance of <see cref="T:System.Data.Objects.ObjectContext"/>. </exception>
		public void LoadProperty(object entity, string navigationProperty, MergeOption mergeOption);

		/// <summary>
		/// Explicitly loads an object that is related to the supplied object by the specified LINQ query and by using the default merge option.
		/// </summary>
		/// <param name="entity">The source object for which related objects are to be loaded.</param><param name="selector">A LINQ expression that defines the related objects to be loaded.</param><typeparam name="TEntity"/><exception cref="T:System.ArgumentException"><paramref name="selector"/> does not supply a valid input parameter.</exception><exception cref="T:System.ArgumentNullException"><paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="entity"/> is in a <see cref="F:System.Data.EntityState.Detached"/>, <see cref="F:System.Data.EntityState.Added,"/> or <see cref="F:System.Data.EntityState.Deleted"/> state,-or-The <paramref name="entity"/> is attached to another instance of <see cref="T:System.Data.Objects.ObjectContext"/>. </exception>
		public void LoadProperty<TEntity>(TEntity entity, Expression<System.Func<TEntity, object>> selector);

		/// <summary>
		/// Explicitly loads an object that is related to the supplied object by the specified LINQ query and by using the specified merge option.
		/// </summary>
		/// <param name="entity">The source object for which related objects are to be loaded.</param><param name="selector">A LINQ expression that defines the related objects to be loaded.</param><param name="mergeOption">The <see cref="T:System.Data.Objects.MergeOption"/> value to use when you load the related objects.</param><typeparam name="TEntity"/><exception cref="T:System.ArgumentException"><paramref name="selector"/> does not supply a valid input parameter.</exception><exception cref="T:System.ArgumentNullException"><paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="entity"/> is in a <see cref="F:System.Data.EntityState.Detached"/>, <see cref="F:System.Data.EntityState.Added,"/> or <see cref="F:System.Data.EntityState.Deleted"/> state,-or-The <paramref name="entity"/> is attached to another instance of <see cref="T:System.Data.Objects.ObjectContext"/>. </exception>
		public void LoadProperty<TEntity>(TEntity entity, Expression<System.Func<TEntity, object>> selector, MergeOption mergeOption);

		/// <summary>
		/// Applies property changes from a detached object to an object already attached to the object context.
		/// </summary>
		/// <param name="entitySetName">The name of the entity set to which the object belongs.</param><param name="changed">The detached object that has property updates to apply to the original object.</param><exception cref="T:System.ArgumentNullException">When <paramref name="entitySetName"/> is null or an empty string.-or-When <paramref name="changed"/> is null.</exception><exception cref="T:System.InvalidOperationException">When the <see cref="T:System.Data.Metadata.Edm.EntitySet"/> from <paramref name="entitySetName"/> does not match the <see cref="T:System.Data.Metadata.Edm.EntitySet"/> of the object’s <see cref="T:System.Data.EntityKey"/>.-or-When the entity is in a state other than <see cref="F:System.Data.EntityState.Modified"/> or <see cref="F:System.Data.EntityState.Unchanged"/>.-or- The original object is not attached to the context.</exception><exception cref="T:System.ArgumentException">When the type of the <paramref name="changed"/> object is not the same type as the original object.</exception>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Obsolete("Use ApplyCurrentValues instead")]
		public void ApplyPropertyChanges(string entitySetName, object changed);

		/// <summary>
		/// Copies the scalar values from the supplied object into the object in the <see cref="T:System.Data.Objects.ObjectContext"/> that has the same key.
		/// </summary>
		/// 
		/// <returns>
		/// The updated object.
		/// </returns>
		/// <param name="entitySetName">The name of the entity set to which the object belongs.</param><param name="currentEntity">The detached object that has property updates to apply to the original object. The entity key of <paramref name="currentEntity"/> must match the <see cref="P:System.Data.Objects.ObjectStateEntry.EntityKey"/> property of an entry in the <see cref="T:System.Data.Objects.ObjectContext"/>. </param><typeparam name="TEntity">The entity type of the object.</typeparam><exception cref="T:System.ArgumentNullException"><paramref name="entitySetName"/> or <paramref name="current"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.Data.Metadata.Edm.EntitySet"/> from <paramref name="entitySetName"/> does not match the <see cref="T:System.Data.Metadata.Edm.EntitySet"/> of the object’s <see cref="T:System.Data.EntityKey"/>.-or-The object is not in the <see cref="T:System.Data.Objects.ObjectStateManager"/> or it is in a <see cref="F:System.Data.EntityState.Detached"/> state.-or- The entity key of the supplied object is invalid.</exception><exception cref="T:System.ArgumentException"><paramref name="entitySetName"/> is an empty string.</exception>
		public TEntity ApplyCurrentValues<TEntity>(string entitySetName, TEntity currentEntity) where TEntity : class;

		/// <summary>
		/// Copies the scalar values from the supplied object into set of original values for the object in the <see cref="T:System.Data.Objects.ObjectContext"/> that has the same key.
		/// </summary>
		/// 
		/// <returns>
		/// The updated object.
		/// </returns>
		/// <param name="entitySetName">The name of the entity set to which the object belongs.</param><param name="originalEntity">The detached object that has original values to apply to the object. The entity key of <paramref name="originalEntity"/> must match the <see cref="P:System.Data.Objects.ObjectStateEntry.EntityKey"/> property of an entry in the <see cref="T:System.Data.Objects.ObjectContext"/>.</param><typeparam name="TEntity">The type of the entity object.</typeparam><exception cref="T:System.ArgumentNullException"><paramref name="entitySetName"/> or <paramref name="original"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.Data.Metadata.Edm.EntitySet"/> from <paramref name="entitySetName"/> does not match the <see cref="T:System.Data.Metadata.Edm.EntitySet"/> of the object’s <see cref="T:System.Data.EntityKey"/>.-or-An <see cref="T:System.Data.Objects.ObjectStateEntry"/> for the object cannot be found in the <see cref="T:System.Data.Objects.ObjectStateManager"/>. -or-The object is in an <see cref="F:System.Data.EntityState.Added"/> or a <see cref="F:System.Data.EntityState.Detached"/> state.-or- The entity key of the supplied object is invalid or has property changes.</exception><exception cref="T:System.ArgumentException"><paramref name="entitySetName"/> is an empty string.</exception>
		public TEntity ApplyOriginalValues<TEntity>(string entitySetName, TEntity originalEntity) where TEntity : class;

		/// <summary>
		/// Attaches an object or object graph to the object context in a specific entity set.
		/// </summary>
		/// <param name="entitySetName">Represents the entity set name, which may optionally be qualified by the entity container name. </param><param name="entity">The <see cref="T:System.Object"/> to attach. </param><exception cref="T:System.ArgumentNullException">The <paramref name="entity"/> is null. </exception><exception cref="T:System.InvalidOperationException">Invalid entity set.-or-The object has a temporary key. -or-The object has an <see cref="T:System.Data.EntityKey"/> and the <see cref="T:System.Data.Metadata.Edm.EntitySet"/> does not match with the entity set passed in as an argument of the method.-or-The object does not have an <see cref="T:System.Data.EntityKey"/> and no entity set is provided.-or-Any object from the object graph has a temporary <see cref="T:System.Data.EntityKey"/>.-or-Any object from the object graph has an invalid <see cref="T:System.Data.EntityKey"/> (for example, values in the key do not match values in the object).-or-The entity set could not be found from a given <paramref name="entitySetName"/> name and entity container name.-or-Any object from the object graph already exists in another state manager.</exception>
		public void AttachTo(string entitySetName, object entity);

		/// <summary>
		/// Attaches an object or object graph to the object context when the object has an entity key.
		/// </summary>
		/// <param name="entity">The object to attach.</param><exception cref="T:System.ArgumentNullException">The <paramref name="entity"/> is null. </exception><exception cref="T:System.InvalidOperationException">Invalid entity key. </exception>
		public void Attach(IEntityWithKey entity);

		/// <summary>
		/// Creates the entity key for a specific object, or returns the entity key if it already exists.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Data.EntityKey"/> of the object.
		/// </returns>
		/// <param name="entitySetName">The fully qualified name of the entity set to which the entity object belongs.</param><param name="entity">The object for which the entity key is being retrieved. </param><exception cref="T:System.ArgumentNullException">When either parameter is null. </exception><exception cref="T:System.ArgumentException">When <paramref name="entitySetName"/> is empty.-or- When the type of the <paramref name="entity"/> object does not exist in the entity set.-or-When the <paramref name="entitySetName"/> is not fully qualified.</exception><exception cref="T:System.InvalidOperationException">When the entity key cannot be constructed successfully based on the supplied parameters.</exception>
		public EntityKey CreateEntityKey(string entitySetName, object entity);

		/// <summary>
		/// Creates a new <see cref="T:System.Data.Objects.ObjectSet`1"/> instance that is used to query, add, modify, and delete objects of the specified entity type.
		/// </summary>
		/// 
		/// <returns>
		/// The new <see cref="T:System.Data.Objects.ObjectSet`1"/> instance.
		/// </returns>
		/// <typeparam name="TEntity">Entity type of the requested <see cref="T:System.Data.Objects.ObjectSet`1"/>.</typeparam><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Data.Objects.ObjectContext.DefaultContainerName"/> property is not set on the <see cref="T:System.Data.Objects.ObjectContext"/>.-or-The specified type belongs to more than one entity set.</exception>
		public ObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class;

		/// <summary>
		/// Creates a new <see cref="T:System.Data.Objects.ObjectSet`1"/> instance that is used to query, add, modify, and delete objects of the specified type and with the specified entity set name.
		/// </summary>
		/// 
		/// <returns>
		/// The new <see cref="T:System.Data.Objects.ObjectSet`1"/> instance.
		/// </returns>
		/// <param name="entitySetName">Name of the entity set for the returned <see cref="T:System.Data.Objects.ObjectSet`1"/>. The string must be qualified by the default container name if the <see cref="P:System.Data.Objects.ObjectContext.DefaultContainerName"/> property is not set on the <see cref="T:System.Data.Objects.ObjectContext"/>. </param><typeparam name="TEntity">Entity type of the requested <see cref="T:System.Data.Objects.ObjectSet`1"/>.</typeparam><exception cref="T:System.InvalidOperationException">The <see cref="T:System.Data.Metadata.Edm.EntitySet"/> from <paramref name="entitySetName"/> does not match the <see cref="T:System.Data.Metadata.Edm.EntitySet"/> of the object’s <see cref="T:System.Data.EntityKey"/>.-or-The <see cref="P:System.Data.Objects.ObjectContext.DefaultContainerName"/> property is not set on the <see cref="T:System.Data.Objects.ObjectContext"/> and the name is not qualified as part of the <paramref name="entitySetName"/> parameter.-or-The specified type belongs to more than one entity set.</exception>
		public ObjectSet<TEntity> CreateObjectSet<TEntity>(string entitySetName) where TEntity : class;

		/// <summary>
		/// Creates an <see cref="T:System.Data.Objects.ObjectQuery`1"/> in the current object context by using the specified query string.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Data.Objects.ObjectQuery`1"/> of the specified type.
		/// </returns>
		/// <param name="queryString">The query string to be executed.</param><param name="parameters">Parameters to pass to the query.</param><typeparam name="T">The entity type of the returned <see cref="T:System.Data.Objects.ObjectQuery`1"/>.</typeparam><exception cref="T:System.ArgumentNullException">The <paramref name="queryString"/> or <paramref name="parameters"/> parameter is null.</exception>
		public ObjectQuery<T> CreateQuery<T>(string queryString, params ObjectParameter[] parameters);

		/// <summary>
		/// Marks an object for deletion.
		/// </summary>
		/// <param name="entity">An object that specifies the entity to delete. The object can be in any state except <see cref="F:System.Data.EntityState.Detached"/>. </param>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public void DeleteObject(object entity);

		/// <summary>
		/// Removes the object from the object context.
		/// </summary>
		/// <param name="entity">Object to be detached. Only the <paramref name="entity"/> is removed; if there are any related objects that are being tracked by the same <see cref="T:System.Data.Objects.ObjectStateManager"/>, those will not be detached automatically.</param><exception cref="T:System.ArgumentNullException">The <paramref name="entity"/> is null. </exception><exception cref="T:System.InvalidOperationException">The <paramref name="entity"/> is not associated with this <see cref="T:System.Data.Objects.ObjectContext"/> (for example, was newly created and not associated with any context yet, or was obtained through some other context, or was already detached).</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public void Detach(object entity);

		/// <summary>
		/// Releases the resources used by the object context.
		/// </summary>
		public void Dispose();

		/// <summary>
		/// Releases the resources used by the object context.
		/// </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing);

		/// <summary>
		/// Returns an object that has the specified entity key.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that is an instance of an entity type.
		/// </returns>
		/// <param name="key">The key of the object to be found.</param><exception cref="T:System.ArgumentNullException">The <paramref name="key"/> parameter is null.</exception><exception cref="T:System.Data.ObjectNotFoundException">The object is not found in either the <see cref="T:System.Data.Objects.ObjectStateManager"/> or the data source.</exception>
		public object GetObjectByKey(EntityKey key);

		/// <summary>
		/// Updates a collection of objects in the object context with data from the data source.
		/// </summary>
		/// <param name="refreshMode">A <see cref="T:System.Data.Objects.RefreshMode"/> value that indicates whether property changes in the object context are overwritten with property values from the data source.</param><param name="collection">An <see cref="T:System.Collections.IEnumerable"/> collection of objects to refresh.</param><exception cref="T:System.ArgumentNullException"><paramref name="collection"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="refreshMode"/> is not valid.</exception><exception cref="T:System.ArgumentException"><paramref name="collection"/> is empty. -or- An object is not attached to the context. </exception>
		public void Refresh(RefreshMode refreshMode, IEnumerable collection);

		/// <summary>
		/// Updates an object in the object context with data from the data source.
		/// </summary>
		/// <param name="refreshMode">One of the <see cref="T:System.Data.Objects.RefreshMode"/> values that specifies which mode to use for refreshing the <see cref="T:System.Data.Objects.ObjectStateManager"/>.</param><param name="entity">The object to be refreshed. </param><exception cref="T:System.ArgumentNullException"><paramref name="collection"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="refreshMode"/> is not valid.</exception><exception cref="T:System.ArgumentException"><paramref name="collection"/> is empty. -or- An object is not attached to the context. </exception>
		public void Refresh(RefreshMode refreshMode, object entity);

		/// <summary>
		/// Persists all updates to the data source and resets change tracking in the object context.
		/// </summary>
		/// 
		/// <returns>
		/// The number of objects in an <see cref="F:System.Data.EntityState.Added"/>, <see cref="F:System.Data.EntityState.Modified"/>, or <see cref="F:System.Data.EntityState.Deleted"/> state when <see cref="M:System.Data.Objects.ObjectContext.SaveChanges"/> was called.
		/// </returns>
		/// <exception cref="T:System.Data.OptimisticConcurrencyException">An optimistic concurrency violation has occurred in the data source.</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public int SaveChanges();

		/// <summary>
		/// Persists all updates to the data source and optionally resets change tracking in the object context.
		/// </summary>
		/// 
		/// <returns>
		/// The number of objects in an <see cref="F:System.Data.EntityState.Added"/>, <see cref="F:System.Data.EntityState.Modified"/>, or <see cref="F:System.Data.EntityState.Deleted"/> state when <see cref="M:System.Data.Objects.ObjectContext.SaveChanges"/> was called.
		/// </returns>
		/// <param name="acceptChangesDuringSave">This parameter is needed for client-side transaction support. If true, the change tracking on all objects is reset after <see cref="M:System.Data.Objects.ObjectContext.SaveChanges(System.Boolean)"/> finishes. If false, you must call the <see cref="M:System.Data.Objects.ObjectContext.AcceptAllChanges"/> method after <see cref="M:System.Data.Objects.ObjectContext.SaveChanges(System.Boolean)"/>. </param><exception cref="T:System.Data.OptimisticConcurrencyException">An optimistic concurrency violation has occurred.</exception>
		[Obsolete("Use SaveChanges(SaveOptions options) instead.")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int SaveChanges(bool acceptChangesDuringSave);

		/// <summary>
		/// Persists all updates to the data source with the specified <see cref="T:System.Data.Objects.SaveOptions"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The number of objects in an <see cref="F:System.Data.EntityState.Added"/>, <see cref="F:System.Data.EntityState.Modified"/>, or <see cref="F:System.Data.EntityState.Deleted"/> state when <see cref="M:System.Data.Objects.ObjectContext.SaveChanges"/> was called.
		/// </returns>
		/// <param name="options">A <see cref="T:System.Data.Objects.SaveOptions"/> value that determines the behavior of the operation.</param><exception cref="T:System.Data.OptimisticConcurrencyException">An optimistic concurrency violation has occurred.</exception>
		public virtual int SaveChanges(SaveOptions options);

		/// <summary>
		/// Ensures that <see cref="T:System.Data.Objects.ObjectStateEntry"/> changes are synchronized with changes in all objects that are tracked by the <see cref="T:System.Data.Objects.ObjectStateManager"/>.
		/// </summary>
		public void DetectChanges();

		/// <summary>
		/// Returns an object that has the specified entity key.
		/// </summary>
		/// 
		/// <returns>
		/// true if the object was retrieved successfully. false if the <paramref name="key"/> is temporary, the connection is null, or the <paramref name="value"/> is null.
		/// </returns>
		/// <param name="key">The key of the object to be found.</param><param name="value">When this method returns, contains the object.</param><exception cref="T:System.ArgumentException">Incompatible metadata for <paramref name="key"/>.</exception><exception cref="T:System.ArgumentNullException"><paramref name="key"/> is null.</exception>
		public bool TryGetObjectByKey(EntityKey key, out object value);

		/// <summary>
		/// Executes a stored procedure or function that is defined in the data source and mapped in the conceptual model, with the specified parameters. Returns a typed <see cref="T:System.Data.Objects.ObjectResult`1"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Data.Objects.ObjectResult`1"/> for the data that is returned by the stored procedure.
		/// </returns>
		/// <param name="functionName">The name of the stored procedure or function. The name can include the container name, such as &lt;Container Name&gt;.&lt;Function Name&gt;. When the default container name is known, only the function name is required.</param><param name="parameters">An array of <see cref="T:System.Data.Objects.ObjectParameter"/> objects.</param><typeparam name="TElement">The entity type of the <see cref="T:System.Data.Objects.ObjectResult`1"/> returned when the function is executed against the data source. This type must implement <see cref="T:System.Data.Objects.DataClasses.IEntityWithChangeTracker"/>.</typeparam><exception cref="T:System.ArgumentException"><paramref name="function"/> is null or empty -or-<paramref name="function"/> is not found.</exception><exception cref="T:System.InvalidOperationException">The entity reader does not support this <paramref name="function"/>.-or-There is a type mismatch on the reader and the <paramref name="function"/>.</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params ObjectParameter[] parameters);

		/// <summary>
		/// Executes the given stored procedure or function that is defined in the data source and expressed in the conceptual model, with the specified parameters, and merge option. Returns a typed <see cref="T:System.Data.Objects.ObjectResult`1"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Data.Objects.ObjectResult`1"/> for the data that is returned by the stored procedure.
		/// </returns>
		/// <param name="functionName">The name of the stored procedure or function. The name can include the container name, such as &lt;Container Name&gt;.&lt;Function Name&gt;. When the default container name is known, only the function name is required.</param><param name="mergeOption">The <see cref="T:System.Data.Objects.MergeOption"/> to use when executing the query. </param><param name="parameters">An array of <see cref="T:System.Data.Objects.ObjectParameter"/> objects.</param><typeparam name="TElement">The entity type of the <see cref="T:System.Data.Objects.ObjectResult`1"/> returned when the function is executed against the data source. This type must implement <see cref="T:System.Data.Objects.DataClasses.IEntityWithChangeTracker"/>.</typeparam><exception cref="T:System.ArgumentException"><paramref name="function"/> is null or empty -or-<paramref name="function"/> is not found.</exception><exception cref="T:System.InvalidOperationException">The entity reader does not support this <paramref name="function"/>.-or-There is a type mismatch on the reader and the <paramref name="function"/>.</exception>
		public ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, MergeOption mergeOption, params ObjectParameter[] parameters);

		/// <summary>
		/// Executes a stored procedure or function that is defined in the data source and expressed in the conceptual model; discards any results returned from the function; and returns the number of rows affected by the execution.
		/// </summary>
		/// 
		/// <returns>
		/// The number of rows affected.
		/// </returns>
		/// <param name="functionName">The name of the stored procedure or function. The name can include the container name, such as &lt;Container Name&gt;.&lt;Function Name&gt;. When the default container name is known, only the function name is required.</param><param name="parameters">An array of <see cref="T:System.Data.Objects.ObjectParameter"/> objects.</param><exception cref="T:System.ArgumentException"><paramref name="function"/> is null or empty -or-<paramref name="function"/> is not found.</exception><exception cref="T:System.InvalidOperationException">The entity reader does not support this <paramref name="function"/>.-or-There is a type mismatch on the reader and the <paramref name="function"/>.</exception>
		public int ExecuteFunction(string functionName, params ObjectParameter[] parameters);

		/// <summary>
		/// Generates an equivalent type that can be used with the Entity Framework for each type in the supplied enumeration.
		/// </summary>
		/// <param name="types">An enumeration of <see cref="T:System.Type"/> objects that represent custom data classes that map to the conceptual model.</param>
		public void CreateProxyTypes(IEnumerable<Type> types);

		/// <summary>
		/// Returns all the existing proxy types.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Collections.Generic.IEnumerable`1"/> of all the existing proxy types.
		/// </returns>
		public static IEnumerable<Type> GetKnownProxyTypes();

		/// <summary>
		/// Returns the entity type of the POCO entity associated with a proxy object of a specified type.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Type"/> of the associated POCO entity.
		/// </returns>
		/// <param name="type">The <see cref="T:System.Type"/> of the proxy object.</param>
		public static Type GetObjectType(Type type);

		/// <summary>
		/// Creates and returns an instance of the requested type .
		/// </summary>
		/// 
		/// <returns>
		/// An instance of the requested type <paramref name="T"/>, or an instance of a derived type that enables <paramref name="T"/> to be used with the Entity Framework. The returned object is either an instance of the requested type or an instance of a derived type that enables the requested type to be used with the Entity Framework.
		/// </returns>
		/// <typeparam name="T">Type of object to be returned.</typeparam>
		public T CreateObject<T>() where T : class;

		/// <summary>
		/// Executes an arbitrary command directly against the data source using the existing connection.
		/// </summary>
		/// 
		/// <returns>
		/// The number of rows affected.
		/// </returns>
		/// <param name="commandText">The command to execute, in the native language of the data source.</param><param name="parameters">An array of parameters to pass to the command.</param>
		public int ExecuteStoreCommand(string commandText, params object[] parameters);

		/// <summary>
		/// Executes a query directly against the data source that returns a sequence of typed results.
		/// </summary>
		/// 
		/// <returns>
		/// An enumeration of objects of type <paramref name="TResult"/>.
		/// </returns>
		/// <param name="commandText">The command to execute, in the native language of the data source.</param><param name="parameters">An array of parameters to pass to the command.</param><typeparam name="TElement"/>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params object[] parameters);

		/// <summary>
		/// Executes a query directly against the data source and returns a sequence of typed results. Specify the entity set and the merge option so that query results can be tracked as entities.
		/// </summary>
		/// 
		/// <returns>
		/// An enumeration of objects of type <paramref name="TResult"/>.
		/// </returns>
		/// <param name="commandText">The command to execute, in the native language of the data source.</param><param name="entitySetName">The entity set of the <paramref name="TResult"/> type. If an entity set name is not provided, the results are not going to be tracked.</param><param name="mergeOption">The <see cref="T:System.Data.Objects.MergeOption"/> to use when executing the query. The default is <see cref="F:System.Data.Objects.MergeOption.AppendOnly"/>.</param><param name="parameters">An array of parameters to pass to the command.</param><typeparam name="TEntity"/>
		public ObjectResult<TEntity> ExecuteStoreQuery<TEntity>(string commandText, string entitySetName, MergeOption mergeOption, params object[] parameters);

		/// <summary>
		/// Translates a <see cref="T:System.Data.Common.DbDataReader"/> that contains rows of entity data to objects of the requested entity type.
		/// </summary>
		/// 
		/// <returns>
		/// An enumeration of objects of type <paramref name="TResult"/>.
		/// </returns>
		/// <param name="reader">The <see cref="T:System.Data.Common.DbDataReader"/> that contains entity data to translate into entity objects.</param><typeparam name="TElement"/><exception cref="T:System.ArgumentNullException">When <paramref name="reader"/> is null.</exception>
		public ObjectResult<TElement> Translate<TElement>(DbDataReader reader);

		/// <summary>
		/// Translates a <see cref="T:System.Data.Common.DbDataReader"/> that contains rows of entity data to objects of the requested entity type, in a specific entity set, and with the specified merge option.
		/// </summary>
		/// 
		/// <returns>
		/// An enumeration of objects of type <paramref name="TResult"/>.
		/// </returns>
		/// <param name="reader">The <see cref="T:System.Data.Common.DbDataReader"/> that contains entity data to translate into entity objects.</param><param name="entitySetName">The entity set of the <paramref name="TResult"/> type.</param><param name="mergeOption">The <see cref="T:System.Data.Objects.MergeOption"/> to use when translated objects are added to the object context. The default is <see cref="F:System.Data.Objects.MergeOption.AppendOnly"/>.</param><typeparam name="TEntity"/><exception cref="T:System.ArgumentNullException">When <paramref name="reader"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">When the supplied <paramref name="mergeOption"/> is not a valid <see cref="T:System.Data.Objects.MergeOption"/> value.</exception><exception cref="T:System.InvalidOperationException">When the supplied <paramref name="entitySetName"/> is not a valid entity set for the <paramref name="TResult"/> type. </exception>
		public ObjectResult<TEntity> Translate<TEntity>(DbDataReader reader, string entitySetName, MergeOption mergeOption);

		/// <summary>
		/// Creates the database by using the current data source connection and the metadata in the <see cref="T:System.Data.Metadata.Edm.StoreItemCollection"/>.
		/// </summary>
		public void CreateDatabase();

		/// <summary>
		/// Deletes the database that is specified as the database in the current data source connection.
		/// </summary>
		public void DeleteDatabase();

		/// <summary>
		/// Checks if the database that is specified as the database in the current data source connection exists on the data source.
		/// </summary>
		/// 
		/// <returns>
		/// true if the database exists.
		/// </returns>
		public bool DatabaseExists();

		/// <summary>
		/// Generates a data definition language (DDL) script that creates schema objects (tables, primary keys, foreign keys) for the metadata in the <see cref="T:System.Data.Metadata.Edm.StoreItemCollection"/>. The <see cref="T:System.Data.Metadata.Edm.StoreItemCollection"/> loads metadata from store schema definition language (SSDL) files.
		/// </summary>
		/// 
		/// <returns>
		/// A DDL script that creates schema objects for the metadata in the <see cref="T:System.Data.Metadata.Edm.StoreItemCollection"/>.
		/// </returns>
		public string CreateDatabaseScript();

		/// <summary>
		/// Gets the connection used by the object context.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Data.Common.DbConnection"/> object that is the connection.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">When the <see cref="T:System.Data.Objects.ObjectContext"/> instance has been disposed.</exception>
		public DbConnection Connection { get; }

		/// <summary>
		/// Gets or sets the default container name.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> that is the default container name.
		/// </returns>
		public string DefaultContainerName { get; set; }

		/// <summary>
		/// Gets the metadata workspace used by the object context.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Data.Metadata.Edm.MetadataWorkspace"/> object associated with this <see cref="T:System.Data.Objects.ObjectContext"/>.
		/// </returns>
		[CLSCompliant(false)]
		public MetadataWorkspace MetadataWorkspace { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the object state manager used by the object context to track object changes.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Data.Objects.ObjectStateManager"/> used by this <see cref="T:System.Data.Objects.ObjectContext"/>.
		/// </returns>
		public ObjectStateManager ObjectStateManager { get; }

		/// <summary>
		/// Gets or sets the timeout value, in seconds, for all object context operations. A null value indicates that the default value of the underlying provider will be used.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Int32"/> value that is the timeout value, in seconds.
		/// </returns>
		/// <exception cref="T:System.ArgumentException">The timeout value is less than 0. </exception>
		public int? CommandTimeout { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; set; }

		/// <summary>
		/// Gets the LINQ query provider associated with this object context.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Linq.IQueryProvider"/> instance used by this object context.
		/// </returns>
		protected internal IQueryProvider QueryProvider { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Data.Objects.ObjectContextOptions"/> instance that contains options that affect the behavior of the <see cref="T:System.Data.Objects.ObjectContext"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Data.Objects.ObjectContextOptions"/> instance that contains options that affect the behavior of the <see cref="T:System.Data.Objects.ObjectContext"/>.
		/// </returns>
		public ObjectContextOptions ContextOptions { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; }

		/// <summary>
		/// Occurs when changes are saved to the data source.
		/// </summary>
		public event EventHandler SavingChanges;

		/// <summary>
		/// Occurs when a new entity object is created from data in the data source as part of a query or load operation.
		/// </summary>
		public event ObjectMaterializedEventHandler ObjectMaterialized;
	}
}
