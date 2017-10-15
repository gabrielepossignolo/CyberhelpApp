﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Cyberhelp.Controls
{
    public partial class TodoItemManager
    {
        static TodoItemManager defaultInstance = new TodoItemManager();
        MobileServiceClient client;

        IMobileServiceTable<TodoItem> todoTable;

        const string offlineDbPath = @"localstore.db";


        private TodoItemManager()
        {
            this.client = new MobileServiceClient(Constants.ApplicationURL);
            this.todoTable = client.GetTable<TodoItem>();
        }

        public static TodoItemManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            set
            {
                defaultInstance = value;
            }
        }

        public MobileServiceClient CurrentClient
        {
            get { return client; }
        }

        public async Task<ObservableCollection<TodoItem>> GetTodoItemsAsync(bool syncItems = false)
        {
            try
            {
                IEnumerable<TodoItem> items = await todoTable
                    .Where(todoItem => !todoItem.Done)
                    .ToEnumerableAsync();

                return new ObservableCollection<TodoItem>(items);
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"Sync error: {0}", e.Message);
            }
            return null;
        }

        public async Task SaveTaskAsync(TodoItem item)
        {
            if (item.Id == null)
            {
                await todoTable.InsertAsync(item);
            }
            else
            {
                await todoTable.UpdateAsync(item);
            }
        }
    }
}
