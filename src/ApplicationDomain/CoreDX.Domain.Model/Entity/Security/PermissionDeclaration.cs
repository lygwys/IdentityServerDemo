﻿using System;
using CoreDX.Domain.Core.Entity;

namespace CoreDX.Domain.Model.Entity.Security
{
    /// <summary>
    /// 角色权限声明
    /// </summary>
    public class RolePermissionDeclaration : RolePermissionDeclaration<int, int>
    {
    }

    /// <summary>
    /// 用户权限声明
    /// </summary>
    public class UserPermissionDeclaration : UserPermissionDeclaration<int, int>
    {
    }

    /// <summary>
    /// 组织权限声明
    /// </summary>
    public class OrganizationPermissionDeclaration : OrganizationPermissionDeclaration<int, int>
    {
    }
}