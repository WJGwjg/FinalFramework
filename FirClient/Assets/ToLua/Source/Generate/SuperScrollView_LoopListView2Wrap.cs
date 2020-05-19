﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using FirClient.Extensions;
using LuaInterface;

public class SuperScrollView_LoopListView2Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SuperScrollView.LoopListView2), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetItemPrefabConfData", GetItemPrefabConfData);
		L.RegFunction("GetItemPrefabList", GetItemPrefabList);
		L.RegFunction("OnItemPrefabChanged", OnItemPrefabChanged);
		L.RegFunction("InitListView", InitListView);
		L.RegFunction("ResetListView", ResetListView);
		L.RegFunction("SetListItemCount", SetListItemCount);
		L.RegFunction("GetShownItemByItemIndex", GetShownItemByItemIndex);
		L.RegFunction("GetShownItemByIndex", GetShownItemByIndex);
		L.RegFunction("GetShownItemByIndexWithoutCheck", GetShownItemByIndexWithoutCheck);
		L.RegFunction("GetIndexInShownItemList", GetIndexInShownItemList);
		L.RegFunction("DoActionForEachShownItem", DoActionForEachShownItem);
		L.RegFunction("NewListViewItem", NewListViewItem);
		L.RegFunction("OnItemSizeChanged", OnItemSizeChanged);
		L.RegFunction("RefreshItemByItemIndex", RefreshItemByItemIndex);
		L.RegFunction("FinishSnapImmediately", FinishSnapImmediately);
		L.RegFunction("MovePanelToItemIndex", MovePanelToItemIndex);
		L.RegFunction("RefreshAllShownItem", RefreshAllShownItem);
		L.RegFunction("RefreshAllShownItemWithFirstIndex", RefreshAllShownItemWithFirstIndex);
		L.RegFunction("RefreshAllShownItemWithFirstIndexAndPos", RefreshAllShownItemWithFirstIndexAndPos);
		L.RegFunction("OnBeginDrag", OnBeginDrag);
		L.RegFunction("OnEndDrag", OnEndDrag);
		L.RegFunction("OnDrag", OnDrag);
		L.RegFunction("GetItemCornerPosInViewPort", GetItemCornerPosInViewPort);
		L.RegFunction("UpdateAllShownItemSnapData", UpdateAllShownItemSnapData);
		L.RegFunction("ClearSnapData", ClearSnapData);
		L.RegFunction("SetSnapTargetItemIndex", SetSnapTargetItemIndex);
		L.RegFunction("ForceSnapUpdateCheck", ForceSnapUpdateCheck);
		L.RegFunction("UpdateListView", UpdateListView);
		L.RegFunction("DestroyListView", DestroyListView);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("mOnBeginDragAction", get_mOnBeginDragAction, set_mOnBeginDragAction);
		L.RegVar("mOnDragingAction", get_mOnDragingAction, set_mOnDragingAction);
		L.RegVar("mOnEndDragAction", get_mOnEndDragAction, set_mOnEndDragAction);
		L.RegVar("mOnSnapItemFinished", get_mOnSnapItemFinished, set_mOnSnapItemFinished);
		L.RegVar("mOnSnapNearestChanged", get_mOnSnapNearestChanged, set_mOnSnapNearestChanged);
		L.RegVar("ArrangeType", get_ArrangeType, set_ArrangeType);
		L.RegVar("IsVertList", get_IsVertList, null);
		L.RegVar("ItemTotalCount", get_ItemTotalCount, null);
		L.RegVar("ContainerTrans", get_ContainerTrans, null);
		L.RegVar("ScrollRect", get_ScrollRect, null);
		L.RegVar("IsDraging", get_IsDraging, null);
		L.RegVar("ItemSnapEnable", get_ItemSnapEnable, set_ItemSnapEnable);
		L.RegVar("SupportScrollBar", get_SupportScrollBar, set_SupportScrollBar);
		L.RegVar("ShownItemCount", get_ShownItemCount, null);
		L.RegVar("ViewPortSize", get_ViewPortSize, null);
		L.RegVar("ViewPortWidth", get_ViewPortWidth, null);
		L.RegVar("ViewPortHeight", get_ViewPortHeight, null);
		L.RegVar("CurSnapNearestItemIndex", get_CurSnapNearestItemIndex, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemPrefabConfData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			SuperScrollView.ItemPrefabConfData o = obj.GetItemPrefabConfData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemPrefabList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData> o = obj.GetItemPrefabList();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnItemPrefabChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.OnItemPrefabChanged(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitListView(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				System.Func<SuperScrollView.LoopListView2,int,SuperScrollView.LoopListViewItem2> arg1 = (System.Func<SuperScrollView.LoopListView2,int,SuperScrollView.LoopListViewItem2>)ToLua.CheckDelegate<System.Func<SuperScrollView.LoopListView2,int,SuperScrollView.LoopListViewItem2>>(L, 3);
				obj.InitListView(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<int, System.Func<SuperScrollView.LoopListView2,int,SuperScrollView.LoopListViewItem2>, SuperScrollView.LoopListViewInitParam>(L, 2))
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				System.Func<SuperScrollView.LoopListView2,int,SuperScrollView.LoopListViewItem2> arg1 = (System.Func<SuperScrollView.LoopListView2,int,SuperScrollView.LoopListViewItem2>)ToLua.ToObject(L, 3);
				SuperScrollView.LoopListViewInitParam arg2 = (SuperScrollView.LoopListViewInitParam)ToLua.ToObject(L, 4);
				obj.InitListView(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<LuaInterface.LuaTable, int, LuaInterface.LuaFunction>(L, 2))
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				LuaTable arg0 = ToLua.ToLuaTable(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				LuaFunction arg2 = ToLua.ToLuaFunction(L, 4);
				obj.InitListView(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SuperScrollView.LoopListView2.InitListView");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetListView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			obj.ResetListView();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetListItemCount(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.SetListItemCount(arg0);
				return 0;
			}
			else if (count == 3)
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.SetListItemCount(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SuperScrollView.LoopListView2.SetListItemCount");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShownItemByItemIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			SuperScrollView.LoopListViewItem2 o = obj.GetShownItemByItemIndex(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShownItemByIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			SuperScrollView.LoopListViewItem2 o = obj.GetShownItemByIndex(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShownItemByIndexWithoutCheck(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			SuperScrollView.LoopListViewItem2 o = obj.GetShownItemByIndexWithoutCheck(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIndexInShownItemList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			SuperScrollView.LoopListViewItem2 arg0 = (SuperScrollView.LoopListViewItem2)ToLua.CheckObject<SuperScrollView.LoopListViewItem2>(L, 2);
			int o = obj.GetIndexInShownItemList(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoActionForEachShownItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			System.Action<SuperScrollView.LoopListViewItem2,object> arg0 = (System.Action<SuperScrollView.LoopListViewItem2,object>)ToLua.CheckDelegate<System.Action<SuperScrollView.LoopListViewItem2,object>>(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj.DoActionForEachShownItem(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NewListViewItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			SuperScrollView.LoopListViewItem2 o = obj.NewListViewItem(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnItemSizeChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.OnItemSizeChanged(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshItemByItemIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.RefreshItemByItemIndex(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FinishSnapImmediately(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			obj.FinishSnapImmediately();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MovePanelToItemIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.MovePanelToItemIndex(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshAllShownItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			obj.RefreshAllShownItem();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshAllShownItemWithFirstIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.RefreshAllShownItemWithFirstIndex(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshAllShownItemWithFirstIndexAndPos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			obj.RefreshAllShownItemWithFirstIndexAndPos(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnBeginDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEndDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnEndDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemCornerPosInViewPort(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				SuperScrollView.LoopListViewItem2 arg0 = (SuperScrollView.LoopListViewItem2)ToLua.CheckObject<SuperScrollView.LoopListViewItem2>(L, 2);
				UnityEngine.Vector3 o = obj.GetItemCornerPosInViewPort(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
				SuperScrollView.LoopListViewItem2 arg0 = (SuperScrollView.LoopListViewItem2)ToLua.CheckObject<SuperScrollView.LoopListViewItem2>(L, 2);
				SuperScrollView.ItemCornerEnum arg1 = (SuperScrollView.ItemCornerEnum)ToLua.CheckObject(L, 3, typeof(SuperScrollView.ItemCornerEnum));
				UnityEngine.Vector3 o = obj.GetItemCornerPosInViewPort(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SuperScrollView.LoopListView2.GetItemCornerPosInViewPort");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateAllShownItemSnapData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			obj.UpdateAllShownItemSnapData();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearSnapData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			obj.ClearSnapData();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSnapTargetItemIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetSnapTargetItemIndex(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForceSnapUpdateCheck(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			obj.ForceSnapUpdateCheck();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateListView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			obj.UpdateListView(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyListView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)ToLua.CheckObject<SuperScrollView.LoopListView2>(L, 1);
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.DestroyListView(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mOnBeginDragAction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action ret = obj.mOnBeginDragAction;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnBeginDragAction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mOnDragingAction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action ret = obj.mOnDragingAction;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnDragingAction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mOnEndDragAction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action ret = obj.mOnEndDragAction;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnEndDragAction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mOnSnapItemFinished(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2> ret = obj.mOnSnapItemFinished;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnSnapItemFinished on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mOnSnapNearestChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2> ret = obj.mOnSnapNearestChanged;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnSnapNearestChanged on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ArrangeType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			SuperScrollView.ListItemArrangeType ret = obj.ArrangeType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ArrangeType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsVertList(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			bool ret = obj.IsVertList;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsVertList on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ItemTotalCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			int ret = obj.ItemTotalCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ItemTotalCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ContainerTrans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			UnityEngine.RectTransform ret = obj.ContainerTrans;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ContainerTrans on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ScrollRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			UnityEngine.UI.ScrollRect ret = obj.ScrollRect;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ScrollRect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsDraging(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			bool ret = obj.IsDraging;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsDraging on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ItemSnapEnable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			bool ret = obj.ItemSnapEnable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ItemSnapEnable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SupportScrollBar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			bool ret = obj.SupportScrollBar;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SupportScrollBar on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ShownItemCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			int ret = obj.ShownItemCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ShownItemCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ViewPortSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			float ret = obj.ViewPortSize;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ViewPortSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ViewPortWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			float ret = obj.ViewPortWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ViewPortWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ViewPortHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			float ret = obj.ViewPortHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ViewPortHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurSnapNearestItemIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			int ret = obj.CurSnapNearestItemIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CurSnapNearestItemIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mOnBeginDragAction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
			obj.mOnBeginDragAction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnBeginDragAction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mOnDragingAction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
			obj.mOnDragingAction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnDragingAction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mOnEndDragAction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
			obj.mOnEndDragAction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnEndDragAction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mOnSnapItemFinished(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2> arg0 = (System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2>)ToLua.CheckDelegate<System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2>>(L, 2);
			obj.mOnSnapItemFinished = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnSnapItemFinished on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mOnSnapNearestChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2> arg0 = (System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2>)ToLua.CheckDelegate<System.Action<SuperScrollView.LoopListView2,SuperScrollView.LoopListViewItem2>>(L, 2);
			obj.mOnSnapNearestChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mOnSnapNearestChanged on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ArrangeType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			SuperScrollView.ListItemArrangeType arg0 = (SuperScrollView.ListItemArrangeType)ToLua.CheckObject(L, 2, typeof(SuperScrollView.ListItemArrangeType));
			obj.ArrangeType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ArrangeType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ItemSnapEnable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.ItemSnapEnable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ItemSnapEnable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SupportScrollBar(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SuperScrollView.LoopListView2 obj = (SuperScrollView.LoopListView2)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.SupportScrollBar = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SupportScrollBar on a nil value");
		}
	}
}
